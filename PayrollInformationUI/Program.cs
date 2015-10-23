using System;
using System.Collections.Generic;
using PayrollInformation;
using PayrollInformation.Models;
using PayrollInformation.Repository;
using PayrollInformation.Infrastructure;

namespace PayrollInformationUI
{
    class Program
    {
        static void Main()
        {
            string selectedOption;
            do
            {
                Console.WriteLine(Environment.NewLine + "*****************************************************");
                Console.WriteLine("Press 1 to search salary information by Employee Name.");
                Console.WriteLine("Press 2 to display salary information for all Employees.");
                Console.WriteLine("Type Exit to exit the application." + Environment.NewLine);
                Console.Write("Please Enter Your Option : ");
                selectedOption = Console.ReadLine();

                if (selectedOption.Equals("1"))
                {
                    Console.Write("\nPlease enter the Employee Name : ");
                    string employeeName = Console.ReadLine();
                    IEmployeesRepository employeesRepository = ServiceLocator.GetEmployeesRepository();
                    IEmployeeSalary employeeSalary = employeesRepository.GetEmployeeSalaryByName(employeeName);
                    IDisplay display = ServiceLocator.GetDisplay();
                    display.EmployeeSalaryInformation(employeeSalary);
                    WaitForKeyAndContinue();
                }
                else if (selectedOption.Equals("2"))
                {
                    IEmployeesRepository employeesRepository = ServiceLocator.GetEmployeesRepository();
                    List<IEmployeeSalaryInGBP> listOfEmployeeSalaryInGbp = employeesRepository.GetEmployeeListOrderedBySalaryInGBP();
                    IDisplay display = ServiceLocator.GetDisplay();
                    display.AllEmployeesOrderedBySalaryInGBP(listOfEmployeeSalaryInGbp);
                    WaitForKeyAndContinue();
                }
                else if (!selectedOption.ToLower().Equals("exit"))
                {
                    Console.WriteLine("Invalid Option.");
                    WaitForKeyAndContinue();
                }

            } while (!selectedOption.ToLower().Equals("exit"));
        }

        private static void WaitForKeyAndContinue()
        {
            Console.Write("\nPress any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
