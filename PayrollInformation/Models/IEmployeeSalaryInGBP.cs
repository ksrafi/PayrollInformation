namespace PayrollInformation.Models
{
    public interface IEmployeeSalaryInGBP
    {
        string EmployeeName { get; set; }
        decimal AnnualAmountInGbp { get; set; }
    }
}
