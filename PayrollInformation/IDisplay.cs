using System.Collections.Generic;
using PayrollInformation.Models;

namespace PayrollInformation
{
    public interface IDisplay
    {
        void EmployeeSalaryInformation(IEmployeeSalary employeeSalary);
        void AllEmployeesOrderedBySalaryInGBP(List<IEmployeeSalaryInGBP> listOfEmployeeSalaryInGbp);
    }
}
