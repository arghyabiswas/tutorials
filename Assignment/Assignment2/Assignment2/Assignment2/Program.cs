using EmployeeModel.BusinessLogic.Classes;
using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reference for the Employee
            IEmployee[] _employee = new IEmployee[3];


            //Object for the Manager
            _employee[0] = new Manager(1);

            //Data to the manager Object
            _employee[0].Email = "employee.Manager@esspl.com";
            _employee[0].Name = "Employee Manager";


            //Object for the Employee One
            _employee[1] = new Employee(2);

            //Data for the Employee One
            _employee[1].Email = "employee.one@esspl.com";
            _employee[1].Name = "Employee One";
            _employee[1].ReportingManager = _employee[0];



            //Object for the Employee Two
            _employee[2] = new Employee(3);

            //Data for Employee Two
            _employee[2].Email = "employee.Two@esspl.com";
            _employee[2].Name = "Employee Two";
            _employee[2].ReportingManager = _employee[0];

            //Memory Allocation for Sub-Ordinates
            ((IManager)_employee[0]).Subordinates = new Employee[2];
            for (int count = 0; count < 2; count++)
            {
                //Putting data to the Sub-Ordinates Property
                ((IManager)_employee[0]).Subordinates[count] = _employee[count + 1];
            }


            //Console for Employee Details
            Console.WriteLine("***** Employee Details *****\n");
            for (int count = 1; count <= 2; count++)
            {
                Console.WriteLine($"Employee Name:- {_employee[count].Name}" +
                    $"\nEmployee Email:- {_employee[count].Email}" +
                   $"\nEmployee Reporting Manager Name:- {_employee[count].ReportingManager.Name}\n\n");
            }


            //Console for Manager Details
            Console.WriteLine("***** Project Manager *****\n");
            Console.WriteLine($"Name of Manager:- {_employee[0].Name}" +
                            $"\nNo of Sub-Ordinates :-{((IManager)_employee[0]).Subordinates.Count()}");

            Console.ReadKey();

        }
    }
}
