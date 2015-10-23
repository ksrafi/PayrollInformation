using System.Collections.Generic;
using System.Linq;
using PayrollInformation.Entities;
using PayrollInformation.Models;

namespace PayrollInformation.Repository
{
    public interface IEmployeesRepository
    {
        IQueryable<Employee> Employees { get; }
        IEmployeeSalary GetEmployeeSalaryByName(string employeeName);
        List<IEmployeeSalaryInGBP> GetEmployeeListOrderedBySalaryInGBP();
    }
}
