using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Entities;
using System.Data.SQLite;

namespace Project
{
    public partial class AddEditOrderForm : Form
    {
        Sale _sale;
        List<Department> _departments;
        private const string _connectionString = "Data Source=salesdb.db";


        public AddEditOrderForm(Sale sale)
        {
            _sale = sale;
            _departments = new List<Department>();
            InitializeComponent();
            FirstNameTextBox.Text = _sale.CustFirstName;
            LastNameTextBox.Text = _sale.CustLastName;
            PhoneNumberTextBox.Text = _sale.CustPhoneNumber;
            EmailTextBox.Text = _sale.CustEmail;
            OrderDateTimePicker.Value = _sale.Date;
            ValueField.Value = (decimal)_sale.Value;
            DeptComboBox.Text = _sale.Department.Name;
        }

        private void DisplayDepartmentsInComboBox()
        {
            var query = "SELECT dept_name FROM Department;";

            using (SQLiteConnection connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                DeptComboBox.Items.Clear();

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    { 
                        DeptComboBox.Items.Add(reader["dept_name"].ToString());   
                    }
                    reader.Close();
                }
              
            }
        }

        private void AddEditOrderForm_Load(object sender, EventArgs e)
        {
            DisplayDepartmentsInComboBox();
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            _sale.CustFirstName = FirstNameTextBox.Text;
            _sale.CustLastName= LastNameTextBox.Text;
            _sale.CustPhoneNumber = PhoneNumberTextBox.Text;
            _sale.CustEmail = EmailTextBox.Text;
            _sale.Date = OrderDateTimePicker.Value;
            _sale.Value = (decimal)ValueField.Value;
            _sale.Department.Name = DeptComboBox.Text;
        }

        #region Validations
        private void FirstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                FNameErrorProvider.SetError((Control)sender, "First name cannot be empty");
            }
            else
            {
                FNameErrorProvider.Clear();
            }
        }

        private void LastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrEmpty(LastNameTextBox.Text))
            {
                LNameErrorProvider.SetError((Control)sender, "Last name cannot be empty");
            }
            else
            {
                LNameErrorProvider.Clear();
            }
        }

        private void EmailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(EmailTextBox.Text))
            {
                LNameErrorProvider.SetError((Control)sender, "Email cannot be empty");
            }
            else if (!(Regex.IsMatch(EmailTextBox.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)))
            {
                EmailErrorProvider.SetError((Control)sender, "Invalid email format");
            }
            else
            {
                EmailErrorProvider.Clear();
            }
        }

        private void ValueField_Validating(object sender, CancelEventArgs e)
        {
            if(ValueField.Value <= 0)
            {
                ValueErrorProvider.SetError((Control)sender, "Value must be higher than 0");
            }
            else
            {
                ValueErrorProvider.Clear();
            }
        }

        private void DepartmentTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(DeptComboBox.Text))
            {
                DeptErrorProvider.SetError((Control)sender, "Department cannot be empty");
            }
            else
            {
                DeptErrorProvider.Clear();
            }
        }

        private void PhoneNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PhoneNumberTextBox.Text))
            {
                DeptErrorProvider.SetError((Control)sender, "Phone number cannot be empty");
            }
            else
            {
                DeptErrorProvider.Clear();
            }
        }

        
        #endregion


    }
}
