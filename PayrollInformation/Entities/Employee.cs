using System.Collections.Generic;

namespace PayrollInformation.Entities
{
    public class Employee
    {
        public Employee()
        {
            this.Salaries = new HashSet<Salary>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public int role_id { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
