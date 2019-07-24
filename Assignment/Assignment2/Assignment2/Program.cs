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

            IEmployee[] employee = new IEmployee[2];
            IManager manager;

           manager = new Manager(1)
            {
                Name = "Ghanshyam Das",
                Email = "gshyam@gmail.com"
            };

            employee[0] = new Employee(2)
            {
                Name = "Alok Nath",
                Email = "alok@gmail.com",
                ReportingManager = manager
            };

            employee[1] = new Employee(3)
            {
                Name = "Basundhara Devi",
                Email = "bdevi@gmail.com",
                ReportingManager = manager
            };

            Console.WriteLine("The List of employees is as follows:-");
            Console.WriteLine("");

            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Name of the employee is " + employee[i].Name + " and his/her email is " + employee[i].Email + " and the name of the reporting manager is " + employee[i].ReportingManager.Name+ ".");
                Console.WriteLine("");

            }

            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(manager);
            employees.Add(employee[0]);
            employees.Add(employee[0]);

            List<IEmployee> employee1 = (from employ in employees
                                               where employ.Name == "Ghanshyam Das"
                                               select employ).ToList();

            foreach(var item in employee1)
            {
                Console.WriteLine("Name of the Manager is " +item.Name+ ".");
            }
            //Console.WriteLine(employee1);

            manager.subordinate = new IEmployee[2];

            manager.subordinate[0] = employee[0];
            manager.subordinate[1] = employee[1];

            Console.WriteLine("Number of subordinats is "+manager.subordinate.Length+".");

            //employee.Length;

            Console.WriteLine("");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
