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

            ///creating array with 3 elements to be held

            IEmployee[] employee = new IEmployee[3];

            ///manager class is implemented by imanager which is inherited by iemployee thus 
            ///creating the value for manager using

            employee[0] = new Manager(1);

            employee[0].Email = "employee.Manager@esspl.com";
            employee[0].Name = "Employee Manager";


            ///entering details for individual employees  with their corresponding reporting manager
            employee[1] = new Employee(2);

            employee[1].Email = "employee.one@esspl.com";
            employee[1].Name = "Employee One";
            employee[1].ReportingManager = employee[0];



            employee[2] = new Employee(3);

            employee[2].Email = "employee.Two@esspl.com";
            employee[2].Name = "Employee Two";
            employee[2].ReportingManager = employee[0];

            ///casting the parent class as child to enter subordinate details for employees using a for loop

            ((IManager)employee[0]).Subordinates = new Employee[2];
            for (int count = 0; count < 2; count++)
            {
                ((IManager)employee[0]).Subordinates[count] = employee[count + 1];
            

                ///printing employee details using another for loop with increasing count till 2 employees
            Console.WriteLine("  Employee Details  \n");
            for (int count = 1; count <= 2; count++)
            {
                Console.WriteLine($"Employee Name:- {employee[count].Name}" +
                    $"\nEmployee Email:- {employee[count].Email}" +
                   $"\nEmployee Reporting Manager Name:- {employee[count].ReportingManager.Name}\n\n");
            }

            ///printing manager details with their subordinates 

            Console.WriteLine(" Project Manager \n");
            Console.WriteLine($"Name of Manager:- {employee[0].Name}" +
                            $"\nNo of Sub-Ordinates :-{((IManager)employee[0]).Subordinates.Count()}");

            Console.ReadKey();

        }
    }
}
    