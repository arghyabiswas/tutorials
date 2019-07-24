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
            //creating the reference of List<IEmployee>
            List<IEmployee> employees = new List<IEmployee>();

            //Add fourteen real record under the collection ( two manager and twelve employee)
            //and Assigning ReportingManager for all employee randomly by manager 1 and manager 2

            IManager manager1 = new Manager(1);
            manager1.email = "manager1@esspl.com";
            manager1.name = "Test Manager1";
            employees.Add(manager1);

            IManager manager2 = new Manager(2);
            manager2.email = "manager2@esspl.com";
            manager2.name = "Test Manager2";
            employees.Add(manager2);

            IEmployee employee1 = new Employee(3);
            employee1.name = "emp1";
            employee1.email = "empl1@esspl.com";
            employee1.ReportingManager = manager1;
            employees.Add(employee1);

            IEmployee employee2 = new Employee(4);
            employee2.name = "emp2";
            employee2.email = "empl2@esspl.com";
            employee2.ReportingManager = manager1;
            employees.Add(employee2);

            IEmployee employee3 = new Employee(5);
            employee3.name = "emp3";
            employee3.email = "empl3@esspl.com";
            employee3.ReportingManager = manager1;
            employees.Add(employee3);

            IEmployee employee4 = new Employee(6);
            employee4.name = "emp4";
            employee4.email = "empl4@esspl.com";
            employee4.ReportingManager = manager1;
            employees.Add(employee4);

            IEmployee employee5 = new Employee(7);
            employee5.name = "emp5";
            employee5.email = "empl5@esspl.com";
            employee5.ReportingManager = manager1;
            employees.Add(employee5);

            IEmployee employee6 = new Employee(8);
            employee6.name = "emp6";
            employee6.email = "empl6@esspl.com";
            employee6.ReportingManager = manager1;
            employees.Add(employee6);

            IEmployee employee7 = new Employee(9);
            employee7.name = "emp7";
            employee7.email = "empl7@esspl.com";
            employee7.ReportingManager = manager2;
            employees.Add(employee7);

            IEmployee employee8 = new Employee(10);
            employee8.name = "emp8";
            employee8.email = "empl8@esspl.com";
            employee8.ReportingManager = manager2;
            employees.Add(employee8);

            IEmployee employee9 = new Employee(11);
            employee9.name = "emp9";
            employee9.email = "empl9@esspl.com";
            employee9.ReportingManager = manager2;
            employees.Add(employee9);

            IEmployee employee10 = new Employee(12);
            employee10.name = "emp10";
            employee10.email = "empl10@esspl.com";
            employee10.ReportingManager = manager2;
            employees.Add(employee10);

            IEmployee employee11 = new Employee(13);
            employee11.name = "emp11";
            employee11.email = "empl11@esspl.com";
            employee11.ReportingManager = manager2;
            employees.Add(employee11);

            IEmployee employee12 = new Employee(14);
            employee12.name = "emp12";
            employee12.email = "empl12@esspl.com";
            employee12.ReportingManager = manager1;
            employees.Add(employee12);

            // LINQ syntax to find the employee name who are working under manager 1
            IEnumerable<IEmployee> empl = from employ in employees
                                         where (employ.ReportingManager!=null && 
                                         employ.ReportingManager == manager1)
                                          select employ;

            Console.WriteLine("Employees Under Manager_1 : ");
            foreach(IEmployee e in empl)
            {
                Console.WriteLine("NAME : "+e.name+"  ,  "+ "EMAIL : "+e.email);
            }
            Console.WriteLine("The No Of Employee Under Manager_1 : " + empl.Count()+"\n");


            //Expression Methods to find the employee who are working under manager2
            List<IEmployee> emp =
                            employees.Where(m => m.ReportingManager != null &&
                                         m.ReportingManager == manager2).ToList<IEmployee>();
            Console.WriteLine("Employees Under Manager_2 : ");
            foreach (IEmployee e in emp)
            {
                Console.WriteLine("NAME : "+e.name + "  ,  "+ "EMAIL : " + e.email);
                
            }
            Console.WriteLine("The No Of Employee Under Manager_2 : " + emp.Count() + "\n");

            //Expression Methods to find the total number of employee exists under the organization
            Console.WriteLine("The Total No Of Employee In The Organization : "+employees.Count);

            Console.ReadLine();
        }
    }
}
