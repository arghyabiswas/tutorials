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

            //Setting Data to the List by SetEmployee() function call
            employee.AddRange(InsertEmployee.SetEmployee());

            //Reference to the IManageEmployee for fetching Employee Details
            IManageEmployee _fetchInformation = new ManageEmployee();

            //Get total Sub-ordinates for Manager id -1 using LINQ
            _fetchInformation.GetSubOrdinatesByLINQ(employee, 1);

            //Get total Sub-ordinates for Manager id -2 using Expression Method
            _fetchInformation.GetSubOrdinates(employee, 2);


            //Get total no of Employee in the Organization
            _fetchInformation.GetTotalEmployee(employee);

            Console.WriteLine("\nPress Any Key to Exit.");
            Console.ReadKey();

        }
    }
}
