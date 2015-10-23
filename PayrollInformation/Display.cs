using System;
using System.Collections.Generic;
using PayrollInformation.Models;

namespace PayrollInformation
{
    public class Display : IDisplay
    {
        public void EmployeeSalaryInformation(IEmployeeSalary employeeSalary)
        {
            Console.WriteLine(Environment.NewLine + "------------------------------------------");
            if (employeeSalary == null || !employeeSalary.EmployeeExists)
                Console.WriteLine("No Records found for this employee.");
            else
            {
                Console.WriteLine("Employee Name                : " + employeeSalary.EmployeeName);
                Console.WriteLine("Salary In Original Currency  : " + employeeSalary.AnnualAmountOriginal + " " + employeeSalary.OriginalCurrency);
                Console.WriteLine("Salary in GBP                : £ " + employeeSalary.AnnualAmountInGbp);
            }
      
        }

        public void AllEmployeesOrderedBySalaryInGBP(List<IEmployeeSalaryInGBP> listOfEmployeeSalaryInGbp)
        {
            Console.WriteLine(Environment.NewLine + "-------------------------");
            if (listOfEmployeeSalaryInGbp.Count > 0)
            {
                foreach (var employeeSalaryInGbp in listOfEmployeeSalaryInGbp)
                {
                    Console.WriteLine(employeeSalaryInGbp.EmployeeName + "   £" + string.Format("{0:0.00}", employeeSalaryInGbp.AnnualAmountInGbp));
                }
            }
            else
                Console.WriteLine("No Employees Found.");
        }
    }
}
