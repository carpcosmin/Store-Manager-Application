using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Entities;

namespace Project
{
    public partial class DepartmentsViewForm : Form
    {
        List<Department> departments;
        private const string _connectionString = "Data Source=salesdb.db";
        public DepartmentsViewForm()
        {
            departments = new List<Department>();
            InitializeComponent();
        }

        private void DisplayDepartments()
        {
            DepartmentsDGV.Rows.Clear();

            foreach (Department department in departments)
            {
                int index = DepartmentsDGV.Rows.Add(new object[]
                {
                        department.Id,
                        department.Name

                }); ;

                DepartmentsDGV.Rows[index].Tag = department;
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
                        departments.Add(dept);
                    }
                }
            }
        }

        private void DepartmentsViewForm_Load(object sender, EventArgs e)
        {
            ReadDepartmentIntoList();
            DisplayDepartments();
        }
    }
}
