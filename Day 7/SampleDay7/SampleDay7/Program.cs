using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel;
using System.Collections;

namespace SampleDay7
{
    class Program
    {
        private static object employee;

        static void Main(string[] args)
        {
            //Manager manager = new Manager();
            //Employee employee = new Employee();

            /*
            IEmployee manager = new Manager(1);
            manager.Name = "Manager";
            manager.Email = "manager@esspl.com";

            IEmployee employee1 = new Employee(2);
            employee1.Name = "Employee 1";
            employee1.Email = "employee@esspl.com";
            employee1.ReportingManager = manager;

            IEmployee employee2 = new Employee(3);
            employee2.Name = "Employee 2";
            employee2.Email = "employee@esspl.com";
            employee2.ReportingManager = manager;

            IEmployee employee3 = new Employee(4);
            employee3.Name = "Employee 3";
            employee3.Email = "employee@esspl.com";
            employee3.ReportingManager = manager;

            IEmployee employee4 = new Employee(3);
            employee4.Name = "Employee 4";
            employee4.Email = "employee@esspl.com";
            employee4.ReportingManager = manager;
            */
            //Console.WriteLine("Employee Name {0} Email {1} Manager Name {2}", employee1.Name, employee1.Email, employee1.ReportingManager.Name);

            /*
            IEmployee[] employees = new IEmployee[5];
            employees[0] = new Manager(1);
            employees[0].Name = "Manager";
            employees[0].Email = "manager@esspl.com";

            employees[1] = new Employee(2);
            employees[1].Name = "Employee 1";
            employees[1].Email = "employee@esspl.com";
            employees[1].ReportingManager = employees[0];

            employees[2] = new Employee(3);
            employees[2].Name = "Employee 2";
            employees[2].Email = "employee@esspl.com";
            employees[2].ReportingManager = employees[0];

            employees[3] = new Employee(4);
            employees[3].Name = "Employee 3";
            employees[3].Email = "employee@esspl.com";
            employees[3].ReportingManager = employees[0];

            employees[4] = new Employee(3);
            employees[4].Name = "Employee 4";
            employees[4].Email = "employee@esspl.com";
            employees[4].ReportingManager = employees[0];
            */

            /*
            ArrayList employees = new ArrayList();


            IEmployee manager = new Manager(1);
            manager.Name = "Manager";
            manager.Email = "manager@esspl.com";

            employees.Add(manager);

            IEmployee employee1 = new Employee(2);
            employee1.Name = "Employee 1";
            employee1.Email = "employee@esspl.com";
            employee1.ReportingManager = manager;
            employees.Add(employee1);

            IEmployee employee2 = new Employee(3);
            employee2.Name = "Employee 2";
            employee2.Email = "employee@esspl.com";
            employee2.ReportingManager = manager;
            employees.Add(employee2);

            IEmployee employee3 = new Employee(4);
            employee3.Name = "Employee 3";
            employee3.Email = "employee@esspl.com";
            employee3.ReportingManager = manager;
            employees.Add(employee3);

            IEmployee employee4 = new Employee(3);
            employee4.Name = "Employee 4";
            employee4.Email = "employee@esspl.com";
            employee4.ReportingManager = manager;
            employees.Add(employee4);


            //[]
            //Array array = new Array()


            Array array = employees.ToArray(typeof(IEmployee[]));

            IEmployee[] employeeArray = (IEmployee[])array;
            ListEmployee(employeeArray);
            */

            Hashtable employees = new Hashtable();

            IEmployee manager = new Manager(1);
            manager.Name = "Manager";
            manager.Email = "manager@esspl.com";

            employees.Add("manager@esspl.com", manager);

            IEmployee employee1 = new Employee(2);
            employee1.Name = "Employee 1";
            employee1.Email = "employee1@esspl.com";
            employee1.ReportingManager = manager;
            employees.Add("employee1@esspl.com", employee1);

            IEmployee employee2 = new Employee(3);
            employee2.Name = "Employee 2";
            employee2.Email = "employee2@esspl.com";
            employee2.ReportingManager = manager;
            employees.Add("employee2@esspl.com", employee2);

            IEmployee employee3 = new Employee(4);
            employee3.Name = "Employee 3";
            employee3.Email = "employee3@esspl.com";
            employee3.ReportingManager = manager;
            employees.Add("employee3@esspl.com", employee3);

            IEmployee employee4 = new Employee(3);
            employee4.Name = "Employee 4";
            employee4.Email = "employee4@esspl.com";
            employee4.ReportingManager = manager;
            employees.Add("employee4@esspl.com", employee4);

            if (employees.ContainsKey("employee5@esspl.com"))
            {
                IEmployee newEmployee = (IEmployee)employees["employee5@esspl.com"];
            }
           
            Console.ReadKey();
        }

        private static void ListEmployee(IEmployee[] employees)
        {
            // 
        }
    }
}
