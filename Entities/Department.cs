using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
    [Serializable]
    public class Department
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Sale Sale { get; set; }
        public Department() 
        {
            
        }

        public Department(long dept_id, string name)
        {
            this.Id = dept_id;
            this.Name = name;
        }

    }
}
