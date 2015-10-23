using System.Collections.Generic;

namespace PayrollInformation.Entities
{
    public class Currency
    {
        public Currency()
        {
            this.Salaries = new HashSet<Salary>();
        }
        public int id { get; set; }
        public string unit { get; set; }
        public decimal conversion_factor { get; set; }

        public virtual ICollection<Salary> Salaries { get; set; }
    }
}
