using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel;
namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating the reference of List<IEmployee>
            List<IEmployee> employees = new List<IEmployee>();

            //Add fourteen real record under the collection ( two manager and twelve employee)
            //and Assigning ReportingManager for all employee randomly by manager 1 and manager 2

            Imanager manager1 = new Manager(1);
            manager1.Email = "manager1@esspl.com";
            manager1.Name = "Test Manager1";
            employees.Add(manager1);

            Imanager manager2 = new Manager(2);
            manager2.Email = "manager2@esspl.com";
            manager2.Name = "Test Manager2";
            employees.Add(manager2);

            IEmployee employee1 = new Employee(3);
            employee1.Name = "emp1dummy";
            employee1.Email = "empl1@esspl.com";
            employee1.ReportingManager = manager1;
            employees.Add(employee1);

            IEmployee employee2 = new Employee(4);
            employee2.Name = "emp2dummy";
            employee2.Email = "empl2@esspl.com";
            employee2.ReportingManager = manager1;
            employees.Add(employee2);

            IEmployee employee3 = new Employee(5);
            employee3.Name = "emp3dummy";
            employee3.Email = "empl3@esspl.com";
            employee3.ReportingManager = manager1;
            employees.Add(employee3);

            IEmployee employee4 = new Employee(6);
            employee4.Name = "emp4dummy";
            employee4.Email = "empl4@esspl.com";
            employee4.ReportingManager = manager1;
            employees.Add(employee4);

            IEmployee employee5 = new Employee(7);
            employee5.Name = "emp5dummy";
            employee5.Email = "empl5@esspl.com";
            employee5.ReportingManager = manager1;
            employees.Add(employee5);

            IEmployee employee6 = new Employee(8);
            employee6.Name = "emp6dummy";
            employee6.Email = "empl6@esspl.com";
            employee6.ReportingManager = manager1;
            employees.Add(employee6);

            IEmployee employee7 = new Employee(9);
            employee7.Name = "emp7dummy";
            employee7.Email = "empl7@esspl.com";
            employee7.ReportingManager = manager2;
            employees.Add(employee7);

            IEmployee employee8 = new Employee(10);
            employee8.Name = "emp8dummy";
            employee8.Email = "empl8@esspl.com";
            employee8.ReportingManager = manager2;
            employees.Add(employee8);

            IEmployee employee9 = new Employee(11);
            employee9.Name = "emp9dummy";
            employee9.Email = "empl9@esspl.com";
            employee9.ReportingManager = manager2;
            employees.Add(employee9);

            IEmployee employee10 = new Employee(12);
            employee10.Name = "emp10dummy";
            employee10.Email = "empl10@esspl.com";
            employee10.ReportingManager = manager2;
            employees.Add(employee10);

            IEmployee employee11 = new Employee(13);
            employee11.Name = "emp11dummy";
            employee11.Email = "empl11@esspl.com";
            employee11.ReportingManager = manager2;
            employees.Add(employee11);

            IEmployee employee12 = new Employee(14);
            employee12.Name = "emp12dummy";
            employee12.Email = "empl12@esspl.com";
            employee12.ReportingManager = manager1;
            employees.Add(employee12);

            // LINQ syntax to find the employee name who are working under manager 1
            IEnumerable<IEmployee> empl = from employ in employees
                                          where (employ.ReportingManager != null &&
                                          employ.ReportingManager == manager1)
                                          select employ;

            Console.WriteLine("Employees Under Manager_1 : ");
            foreach (IEmployee e in empl)
            {
                Console.WriteLine("NAME : " + e.Name + "  ,  " + "EMAIL : " + e.Email);
            }
            Console.WriteLine("The No Of Employee Under Manager_1 : " + empl.Count() + "\n");


            //Expression Methods to find the employee who are working under manager2
            List<IEmployee> emp =
                            employees.Where(m => m.ReportingManager != null &&
                                         m.ReportingManager == manager2).ToList<IEmployee>();
            Console.WriteLine("Employees Under Manager_2 : ");
            foreach (IEmployee e in emp)
            {
                Console.WriteLine("NAME : " + e.Name + "  ,  " + "EMAIL : " + e.Email);

            }
            Console.WriteLine("The No Of Employee Under Manager_2 : " + emp.Count() + "\n");

            //Expression Methods to find the total number of employee exists under the organization
            Console.WriteLine("The Total No Of Employee In The Organization : " + employees.Count);

            Console.ReadLine();
        }
    }
}
