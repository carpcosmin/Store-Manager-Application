using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    [Serializable]
    public class Sale
    {
        public long Id { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }

        public string CustPhoneNumber { get; set; }
        public string CustEmail { get; set; }
        public decimal Value { get; set; }

        public DateTime Date = DateTime.Now;

        public Department Department { get; set; }

        
     
        public Sale() 
        { 
            Department = new Department();
        }

        public Sale(string cust_first_name, string cust_last_name, string cust_phone_number, string cust_email, decimal value, DateTime date, string name)
        {
            this.CustFirstName = cust_first_name;
            this.CustLastName = cust_last_name;
            this.CustPhoneNumber = cust_phone_number;
            this.CustEmail = cust_email;
            this.Value = value;
            this.Date = date;
            Department = new Department();
            this.Department.Name = name;
        }

        public Sale(long id, string cust_first_name, string cust_last_name, string cust_phone_number, string cust_email, decimal value, DateTime date, string name)
            : this(cust_first_name, cust_last_name, cust_phone_number, cust_email, value, date, name)
        {
            Id = id;
        }

    }
}
