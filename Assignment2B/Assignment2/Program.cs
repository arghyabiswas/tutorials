using Assignment2.BusinessLogic.Classes;
using Assignment2.BusinessLogic.Interfaces;
using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaration of List type of IEmployee
            List<IEmployee> employee = new List<IEmployee>();

            //Adding Data to the List by calling SetEmployee function
            employee.AddRange(InsertEmployee.SetEmployee());

            
            IManageEmployee _fetchInfo = new ManageEmployee();

            //for total number of subordinates of manager
            _fetchInfo.GetSubOrdinatesByLINQ(employee, 1);

            //For total number of subordinates
            _fetchInfo.GetSubOrdinates(employee, 2);


            //For total number of employees
            _fetchInfo.GetTotalEmployee(employee);

           
            Console.ReadKey();

        }
    }
}
