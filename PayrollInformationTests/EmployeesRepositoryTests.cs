using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PayrollInformation.Infrastructure;
using PayrollInformation.Models;
using PayrollInformation.Repository;

namespace PayrollInformationTests
{
    [TestClass]
    public class EmployeesRepositoryTests
    {
        [TestMethod]
        public void GetEmployeeSalaryByName_InvalidName_EmployeeExistsFalse()
        {
            IEmployeesRepository employeesRepository = ServiceLocator.GetEmployeesRepository();
            IEmployeeSalary employeeSalary = employeesRepository.GetEmployeeSalaryByName("invalid employee");
            Assert.AreEqual(employeeSalary.EmployeeExists,false);
        }

        [TestMethod]
        public void GetEmployeeListOrderedBySalaryInGBP_ReturnsList()
        {
            IEmployeesRepository employeesRepository = ServiceLocator.GetEmployeesRepository();
            List<IEmployeeSalaryInGBP> employeeSalary = employeesRepository.GetEmployeeListOrderedBySalaryInGBP();
            const int count = 0;
            Assert.AreNotEqual(count,employeeSalary.Count);
        }
    }
}
