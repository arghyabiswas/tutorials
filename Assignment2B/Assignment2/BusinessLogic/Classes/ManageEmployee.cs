using Assignment2.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeModel.BusinessLogic.Interfaces;

namespace Assignment2.BusinessLogic.Classes
{
    class ManageEmployee : IManageEmployee
    {

        /// <summary>
        /// Prints Details of All the Employee
        /// </summary>
        /// <param name="employee">List of Employee</param>
        public void GetEmployeeDetails(List<IEmployee> employee)
        {
            if (employee.Count != 0)
            {
                foreach (var item in employee)
                {
                    Console.WriteLine($"\n EmpID-{item.EmployeeId}, Email-{item.Email}, Name-{item.Name}");
                }
            }
            else
            {
                Console.WriteLine("\nNo employee Present in the Organization");
            }
        }


        /// <summary>
        /// Prints the Employee Details under a Manager, Uses Expression Mathod
        /// </summary>
        /// <param name="employee">List of Employee</param>
        /// <param name="employeeId">ManagerId</param>
        public void GetSubOrdinates(List<IEmployee> employee, int employeeId)
        {
            if (employee.Count != 0)
            {
                List<IEmployee> subOrdinates = employee
                                               .Where(m => m.ReportingManager != null && m.ReportingManager.EmployeeId == employeeId)
                                               .ToList();
                if (subOrdinates.Count != 0)
                {
                    Console.WriteLine($"\nSub-Ordinates Present for the EmployeeId:- {employeeId}");
                    foreach (var item in subOrdinates)
                    {
                        Console.WriteLine($"\n{item.Name}  - {item.Email} - {item.EmployeeId} ");
                    }

                }
                else
                {
                    Console.WriteLine($"\nNo Sub-Ordinates Present for the EmployeeId:- {employeeId}");
                }

            }
            else
            {
                Console.WriteLine("\nNo Employee Present in the Organization");
            }
        }

        /// <summary>
        /// Prints the Employee Details under a Manager, Uses LINQ Query
        /// </summary>
        /// <param name="employee">List of Employee</param>
        /// <param name="employeeId">ManagerId</param>
        public void GetSubOrdinatesByLINQ(List<IEmployee> employee, int employeeId)
        {
            if (employee.Count != 0)
            {
                List<IEmployee> subOrdinates = (from data in employee
                                                where data.ReportingManager != null &&
                                                      data.ReportingManager.EmployeeId == employeeId
                                                select data).ToList();

                if (subOrdinates.Count != 0)
                {
                    Console.WriteLine($"\nSub-Ordinates Present for the EmployeeId:- {employeeId}");
                    foreach (var item in subOrdinates)
                    {
                        Console.WriteLine($"\n{item.Name}  - {item.Email} - {item.EmployeeId} ");
                    }

                }
                else
                {
                    Console.WriteLine($"\nNo Sub-Ordinates Present for the EmployeeId:- {employeeId}");
                }

            }
            else
            {
                Console.WriteLine("\nNo Employee Present in the Organization");
            }
        }


        /// Prints Total Number of Employee Present in the Organization
        /// </summary>
        /// <param name="employee">List of Employee</param>
        public void GetTotalEmployee(List<IEmployee> employee)
        {
            if (employee.Count != 0)
            {
                int totalEmployee = employee.Count;
                Console.WriteLine($"\nTotal No of Employee Present in the Organization is:- {totalEmployee}");
            }
            else
            {
                Console.WriteLine("\nNo employee Present in the Organization");
            }
        }
    }
}
