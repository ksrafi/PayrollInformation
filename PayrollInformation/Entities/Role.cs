using System.Collections.Generic;

namespace PayrollInformation.Entities
{
    public class Role
    {
        public Role()
        {
            this.Employees = new HashSet<Employee>();
        }

        public int id { get; set; }
        public string name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
