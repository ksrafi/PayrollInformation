namespace PayrollInformation.Models
{
    public class EmployeeSalaryInGBP : IEmployeeSalaryInGBP
    {
        public string EmployeeName { get; set; }
        public decimal AnnualAmountInGbp { get; set; }
    }
}
