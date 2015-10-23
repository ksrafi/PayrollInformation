namespace PayrollInformation.Models
{
    public class EmployeeSalary : IEmployeeSalary
    {
        public bool EmployeeExists { get; set; }
        public string EmployeeName { get; set; }
        public decimal AnnualAmountOriginal { get; set; }
        public string OriginalCurrency { get; set; }
        public decimal AnnualAmountInGbp { get; set; }

    }
}
