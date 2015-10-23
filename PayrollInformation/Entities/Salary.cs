using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollInformation.Entities
{
    public class Salary
    {
        public int id { get; set; }
        [Column("employee_id")]
        public int EmployeeId { get; set; }
        [Column("currency")]
        public int CurrencyId { get; set; }
        public long annual_amount { get; set; }

        [ForeignKey("CurrencyId")]
        public virtual Currency CurrencyFK { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee EmployeeFK { get; set; }
    }
}
