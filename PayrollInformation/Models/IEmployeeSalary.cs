namespace PayrollInformation.Models
{
    public interface IEmployeeSalary
    {
        bool EmployeeExists { get; set; }
        string EmployeeName { get; set; }
        decimal AnnualAmountOriginal { get; set; }
        string OriginalCurrency { get; set; }
        decimal AnnualAmountInGbp { get; set; }
    }
}
