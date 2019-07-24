using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeModel;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            IEmployee[] employee = new IEmployee[3];

            employee[0] = new Manager(1)
            {
                Name = "Ghanshyam Das",
                Email = "gshyam@gmail.com"
            };

            employee[1] = new Employee(2)
            {
                Name = "Alok Nath",
                Email = "alok@gmail.com",
                ReportingManager = employee[0]
            };

            employee[2] = new Employee(3)
            {
                Name = "Basundhara Devi",
                Email = "bdevi@gmail.com",
                ReportingManager = employee[0]
            };

            for (int i = 1; i < 3; i++)
            {

                Console.WriteLine("Name of the employee is " + employee[i].Name + " and his/her email is " + employee[i].Email + " and the name of the reporting manager is " + employee[i].ReportingManager.Name+ ".");
                Console.WriteLine("");

            }

            //employee.Length;

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
