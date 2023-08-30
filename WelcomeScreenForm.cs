using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Entities;

namespace Project
{
    public partial class WelcomeScreenForm : Form
    {
        public WelcomeScreenForm()
        {
            InitializeComponent();
            Shop shop = new Shop();
            //List<Department> departments = new List<Department>();
            List<Sale> sales = new List<Sale>(); 
        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            Form form = new SalesListForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private void BtnDeptInfo_Click(object sender, EventArgs e)
        {
            Form form = new DepartmentsViewForm();
            if(form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
