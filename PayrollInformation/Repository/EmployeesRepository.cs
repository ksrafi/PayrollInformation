using System;
using System.Collections.Generic;
using System.Linq;
using PayrollInformation.Concrete;
using PayrollInformation.Entities;
using PayrollInformation.Infrastructure;
using PayrollInformation.Models;

namespace PayrollInformation.Repository
{
    public class EmployeesRepository : IEmployeesRepository
    {
       private readonly PayrollInformationDbContext _dbContext = new PayrollInformationDbContext();
        public IQueryable<Employee> Employees 
        {
            get { return _dbContext.Employees; } 
        }

        public IEmployeeSalary GetEmployeeSalaryByName(string employeeName )
        {
            var employeeSalary = ServiceLocator.GetEmployeeSalary();
            try
            {
                var employee = _dbContext.Employees.FirstOrDefault(x => x.name == employeeName);
                if (employee != null)
                {
                    var salaryRecord = employee.Salaries.FirstOrDefault();
                    if (salaryRecord != null)
                    {
                        var amountOriginal = salaryRecord.annual_amount;
                        var amountGBP = Math.Round((salaryRecord.annual_amount / salaryRecord.CurrencyFK.conversion_factor),2);
                        employeeSalary.EmployeeExists = true;
                        employeeSalary.EmployeeName = employee.name;
                        employeeSalary.AnnualAmountOriginal = amountOriginal;
                        employeeSalary.OriginalCurrency = salaryRecord.CurrencyFK.unit;
                        employeeSalary.AnnualAmountInGbp = amountGBP;
                    }
                }
                else
                    employeeSalary.EmployeeExists = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Exception Occured :" + ex);
            }

           return employeeSalary;
        }

        public List<IEmployeeSalaryInGBP> GetEmployeeListOrderedBySalaryInGBP()
        {
            var listOfEmployees = new List<IEmployeeSalaryInGBP>();
            try
            {
                listOfEmployees = (from e in _dbContext.Employees
                              join s in _dbContext.Salaries on e.id equals s.EmployeeId
                              join c in _dbContext.Currencies on s.CurrencyId equals c.id
                              where e.role_id == 1
                              select new EmployeeSalaryInGBP
                              {
                                  EmployeeName = e.name, 
                                  AnnualAmountInGbp = Math.Round((s.annual_amount / c.conversion_factor), 2)
                              }).OrderByDescending(x => x.AnnualAmountInGbp).ToList<IEmployeeSalaryInGBP>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Exception Occured :" + ex);
            }

            return listOfEmployees;
        }
    }
}
