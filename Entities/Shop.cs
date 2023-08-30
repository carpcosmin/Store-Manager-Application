using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    public class Shop
    {
        private string Name { get; set; }
        private string Address { get; set; }
        List<Department> Departments { get; set; }
        List<Sale> Sales { get; set; }
       

        public Shop() 
        {
            Departments = new List<Department>();
            Sales = new List<Sale>();

        }

        public Shop(string name, string address, List<Department> departments, List<Sale> sales)
        {
            this.Name = name;
            this.Address = address;
            this.Departments = departments;
            this.Sales = sales;
        }
    }
}
