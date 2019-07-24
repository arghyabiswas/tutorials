using BusinessModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialDay8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList anArray = new ArrayList();

            Hashtable aHashTable = new Hashtable();

            aHashTable.Add("item1", "Item 1 Name");
            aHashTable.Add("item2", 9999);


            Dictionary<int, string> aDict = new Dictionary<int, string>();
            aDict.Add(1, "ASP.NET");
            //aDict.Add(2, 1234);
            */

            /*
            SortedList employees = new SortedList();


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
            */

            IEmployee manager = new Manager(1);
            manager.Name = "Manager";
            manager.Email = "manager@esspl.com";

            // Deep Copy
            IEmployee manager2 = manager.Copy();

            

            IEmployee employee1 = new Employee(2);
            employee1.Name = "Employee 1";
            employee1.Email = "employee1@esspl.com";
            employee1.ReportingManager = manager;

            IEmployee employee2 = new Employee(3);
            employee2.Name = "Employee 2";
            employee2.Email = "employee2@esspl.com";
            employee2.ReportingManager = manager;

            IEmployee employee3 = new Employee(4);
            employee3.Name = "Employee 2";
            employee3.Email = "employee3@esspl.com";
            employee3.ReportingManager = manager;

            IEmployee employee4 = new Employee(3);
            employee4.Name = "Employee 4";
            employee4.Email = "employee4@esspl.com";
            employee4.ReportingManager = manager;

            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(manager);
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);

            //IEmployee firstEmployee = employees.First(p => p.Email == "employee2@esspl.com");

            // firstEmployee = employees.First(p => p.Name == "TEST");



            employees.FirstOrDefault(p => p.Name == "Employee ABC" && p.Email == "123");

            List<IEmployee> filteredEmployeeList = employees
                                                        .Where(p => p.Name.StartsWith("M"))
                                                        .ToList<IEmployee>();

            Console.WriteLine(filteredEmployeeList.Count);
            Console.ReadKey();

            IEnumerable<IEmployee> employees1 = from employ in employees
                                                where employ.Name == "TEST"
                                                select employ;

        }
    }
}
