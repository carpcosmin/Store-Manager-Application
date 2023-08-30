using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Project.Entities;
using Newtonsoft.Json;
using System.Data.SQLite;

namespace Project
{
    public partial class SalesListForm : Form
    {
        #region Attributes
        private Shop shop;
        public List<Sale> sales;
        private const string _connectionString = "Data Source=salesdb.db";
        public List<Department> _departments;
        #endregion
        public SalesListForm()
        {
            shop = new Shop();
            sales = new List<Sale>();
            _departments = new List<Department>();
            InitializeComponent();
        }

        #region Methods
        private void DisplaySales()
        {
            SalesDGV.Rows.Clear();

            foreach (Sale sale in sales)
            {
                int index = SalesDGV.Rows.Add(new object[]
                {
                        sale.Id,
                        sale.CustFirstName,
                        sale.CustLastName,
                        sale.CustPhoneNumber,
                        sale.CustEmail,
                        sale.Value,
                        sale.Date,
                        sale.Department.Name

                }); ;

                SalesDGV.Rows[index].Tag = sale;
            }
        }
        #endregion

        #region Events
        private void SalesListForm_Load(object sender, EventArgs e)
        {
            ReadSale();
            ReadDepartmentIntoList();
            DisplaySales();
            
        }

        private void SerializeMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            Department dept = new Department();
            AddEditOrderForm addForm = new AddEditOrderForm(sale);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                sales.Add(sale);
                DisplaySales();
            }
            try
            {
                InsertSale(sale);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BtnEdit_Click(object sender, EventArgs e)
            {
            if (SalesDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose an order");
                return;

            }

            if (SalesDGV.SelectedRows.Count > 0)
            {
                var sale = (Sale)SalesDGV.SelectedRows[0].Tag;

                AddEditOrderForm form = new AddEditOrderForm(sale);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    DisplaySales();
                }
                try
                {
                    UpdateSale(sale);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (SalesDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose an order");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delete order", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) ==
                DialogResult.Yes)
            {
                DataGridViewRow row = SalesDGV.SelectedRows[0];
                Sale sale = (Sale)row.Tag;
                sales.Remove(sale);
                try
                {
                    DeleteSale(sale);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                DisplaySales();
            }
        }
        #endregion

        #region XML
        private void btnSerializeXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            using (FileStream stream = File.Create("SerializedXML.xml"))
                serializer.Serialize(stream, sales);
            MessageBox.Show("XML Serialization Completed!");
        }

        private void btnDeserializeXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
            using (FileStream stream = File.OpenRead("SerializedXML.xml"))
            {
                sales = (List<Sale>)serializer.Deserialize(stream);
                DisplaySales();
            }
            MessageBox.Show("XML Deserialization Completed!");
        }


        #endregion

        #region Binary
        private void btnSerializeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.Create("SerializedBinary.bin"))
                formatter.Serialize(stream, sales);
            MessageBox.Show("Binary Serialization Completed!");
        }

        private void btnDeserializeBinary_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("SerializedBinary.bin"))
            {
                sales = (List<Sale>)formatter.Deserialize(stream);
                DisplaySales();
            }
            MessageBox.Show("Binary Deserialization Completed!");
        }

        #endregion

        #region JSON
        private void btnSerializeJSON_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter writer = File.CreateText("SerializedJSON.json"))
            {
                serializer.Serialize(writer, sales);
            }
            MessageBox.Show("JSON Serialization Completed!");
        }

        private void btnDeserializeJSON_Click(object sender, EventArgs e)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader reader = new StreamReader("SerializedJSON.json"))
            {
                sales = (List<Sale>)serializer.Deserialize(reader, typeof(List<Sale>));
                DisplaySales();
            }
            MessageBox.Show("JSON Deserialization Completed!");
        }

        #endregion

        #region Text
        private void btnSerializeTextFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("FirstName, LastName, Email, Phone Number, Date, Value, Department");

                    foreach (var sale in sales)
                    {
                        sw.WriteLine("\"{0}\", \"{1}\", \"{2}\""
                            , sale.CustFirstName.Replace("\"", "\"\"")
                            , sale.CustLastName.Replace("\"", "\"\"")
                            , sale.CustPhoneNumber.Replace("\"", "\"\"")
                            , sale.CustEmail.Replace("\"", "\"\"")
                            , sale.Date.ToShortDateString()
                            , sale.Value
                            , sale.Department.Name.Replace("\"", "\"\"")); ;
                    }
                    MessageBox.Show(saveFileDialog.FileName + " created!");
                }
            }

        }
        #endregion

        #region Database
        private void InsertSale(Sale sale)
        {
            var query = "INSERT INTO Sale (cust_first_name, cust_last_name, cust_phone_number, cust_email, value, date, department) VALUES (@firstName, @lastName, @phoneNumber, @email, @value, @date, @department);";
            query += "SELECT last_insert_rowid();";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@firstName", sale.CustFirstName);
                command.Parameters.AddWithValue("@lastName", sale.CustLastName);
                command.Parameters.AddWithValue("@phoneNumber", sale.CustPhoneNumber);
                command.Parameters.AddWithValue("@email", sale.CustEmail);
                command.Parameters.AddWithValue("@value", sale.Value);
                command.Parameters.AddWithValue("@date", sale.Date.ToString());
                command.Parameters.AddWithValue("@department", sale.Department.Name);

                var id = (long)command.ExecuteScalar();
                sale.Id = id;

                sales.Add(sale);
            }
        }

        private void ReadSale()
        {
            var query = "SELECT * FROM Sale;";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = (long)reader["id"];
                        var firstName = (string)reader["cust_first_name"];
                        var lastName = (string)reader["cust_last_Name"];
                        var phoneNumber = (string)reader["cust_phone_number"];
                        var email = (string)reader["cust_email"];
                        var value = (double)reader["value"];
                        var date = DateTime.Parse((string)reader["date"]);
                        var department = (string)reader["department"];

                        var sale = new Sale(id, firstName, lastName, phoneNumber, email, (decimal)value, date, department);
                        sales.Add(sale);
                    }
                }
            }
        }

        private void UpdateSale(Sale sale)
        {
            var query = "UPDATE Sale SET cust_first_name = @firstName, cust_last_name = @lastName, cust_phone_number = @phoneNumber, cust_email = @email, value = @value, date = @date, department = @department WHERE id = @id;";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", sale.Id);
                command.Parameters.AddWithValue("@firstName", sale.CustFirstName);
                command.Parameters.AddWithValue("@lastName", sale.CustLastName);
                command.Parameters.AddWithValue("@phoneNumber", sale.CustPhoneNumber);
                command.Parameters.AddWithValue("@email", sale.CustEmail);
                command.Parameters.AddWithValue("@value", sale.Value);
                command.Parameters.AddWithValue("@date", sale.Date.ToString());
                command.Parameters.AddWithValue("@department", sale.Department.Id);

                command.ExecuteScalar();
            }
        }

        private void DeleteSale(Sale sale)
        {
            var query = "DELETE FROM Sale WHERE Id = @id;";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", sale.Id);
                command.ExecuteNonQuery();
            }
        }

        private void ReadDepartmentIntoList()
        {
            var query = "SELECT dept_id, dept_name FROM Department;";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = (long)reader["dept_id"];
                        var name = (string)reader["dept_name"];
                        var dept = new Department(id, name);
                        _departments.Add(dept);
                    }
                }
            }
        }

        #endregion
    }
}

    


