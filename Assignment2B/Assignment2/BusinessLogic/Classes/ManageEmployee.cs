using Assignment2.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeModel.BusinessLogic.Interfaces;

namespace Assignment2.BusinessLogic.Classes
{
    class ManageEmployee : IManageEmployee
    {

        
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
                Console.WriteLine("\nNo employee Present");
            }
        }


        
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
                Console.WriteLine("\nNo Employee Present");
            }
        }

        
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
                Console.WriteLine("\nNo Employee Present");
            }
        }


       
        public void GetTotalEmployee(List<IEmployee> employee)
        {
            if (employee.Count != 0)
            {
                int totalEmp = employee.Count;
                Console.WriteLine($"\nTotal Employees Present in the Organization is:- {totalEmp}");
            }
            else
            {
                Console.WriteLine("\nNo employee Present ");
            }
        }
    }
}
