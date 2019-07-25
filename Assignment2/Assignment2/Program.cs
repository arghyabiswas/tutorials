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
            List<IEmployee> employee = new List<IEmployee>();

            //Add fourteen real record under the collection ( two manager and twelve employee)
            //and Assigning ReportingManager for all employee randomly by manager 1 and manager 2

            IManager manager1 = new Manager(1);
            manager1.Email = "manager1@esspl.com";
            manager1.Name = "Test Manager1";
            employee.Add(manager1);

            IManager manager2 = new Manager(2);
            manager2.Email = "manager2@esspl.com";
            manager2.Name = "Test Manager2";
            employee.Add(manager2);

            IEmployee employee1 = new Employee(3);
            employee1.Name = "Aseem";
            employee1.Email = "aseem@esspl.com";
            employee1.ReportingManager = manager1;
            employee.Add(employee1);

            IEmployee employee2 = new Employee(4);
            employee2.Name = "Monalisa";
            employee2.Email = "monalisa@esspl.com";
            employee2.ReportingManager = manager1;
            employee.Add(employee2);

            IEmployee employee3 = new Employee(5);
            employee3.Name = "Ashutosh";
            employee3.Email = "ashutosh@esspl.com";
            employee3.ReportingManager = manager1;
            employee.Add(employee3);

            IEmployee employee4 = new Employee(6);
            employee4.Name = "Nikolash";
            employee4.Email = "Nikolash@esspl.com";
            employee4.ReportingManager = manager1;
            employee.Add(employee4);

            IEmployee employee5 = new Employee(7);
            employee5.Name = "Chiranjeev";
            employee5.Email = "chiranjeev@esspl.com";
            employee5.ReportingManager = manager1;
            employee.Add(employee5);

            IEmployee employee6 = new Employee(8);
            employee6.Name = "Deepak";
            employee6.Email = "Deepak@esspl.com";
            employee6.ReportingManager = manager1;
            employee.Add(employee6);

            IEmployee employee7 = new Employee(9);
            employee7.Name = "Sobhana";
            employee7.Email = "sobhana@esspl.com";
            employee7.ReportingManager = manager2;
            employee.Add(employee7);

            IEmployee employee8 = new Employee(10);
            employee8.Name = "Ashirwad";
            employee8.Email = "ashirwad@esspl.com";
            employee8.ReportingManager = manager2;
            employee.Add(employee8);

            IEmployee employee9 = new Employee(11);
            employee9.Name = "Bismaya";
            employee9.Email = "Bismaya@esspl.com";
            employee9.ReportingManager = manager2;
            employee.Add(employee9);

            IEmployee employee10 = new Employee(12);
            employee10.Name = "Vishal";
            employee10.Email = "vishal@esspl.com";
            employee10.ReportingManager = manager2;
            employee.Add(employee10);

            IEmployee employee11 = new Employee(13);
            employee11.Name = "Amlan";
            employee11.Email = "Amlan@esspl.com";
            employee11.ReportingManager = manager2;
            employee.Add(employee11);

            IEmployee employee12 = new Employee(14);
            employee12.Name = "Utkal";
            employee12.Email = "utkal@esspl.com";
            employee12.ReportingManager = manager1;
            employee.Add(employee12);

            // LINQ syntax to find the employee name who are working under manager 1
            IEnumerable<IEmployee> empl = from employ in employee
                                          where (employ.ReportingManager != null &&
                                          employ.ReportingManager == manager1)
                                          select employ;

            Console.WriteLine("Employees Under Manager1 : ");
            foreach (IEmployee e in empl)
            {
                Console.WriteLine("NAME : " + e.Name + "  ,  " + "EMAIL : " + e.Email);
            }
            Console.WriteLine("The No Of Employee Under Manager1 : " + empl.Count() + "\n");


            //Expression Methods to find the employee who are working under manager2
            List<IEmployee> emp =
                            employee.Where(m => m.ReportingManager != null &&
                                         m.ReportingManager == manager2).ToList<IEmployee>();
            Console.WriteLine("Employees Under Manager2 : ");
            foreach (IEmployee e in emp)
            {
                Console.WriteLine("NAME : " + e.Name + "  ,  " + "EMAIL : " + e.Email);

            }
            Console.WriteLine("The No Of Employee Under Manager2 : " + emp.Count() + "\n");

            //Expression Methods to find the total number of employee exists under the organization
            Console.WriteLine("The Total No Of Employee In The Organization : " + employee.Count);

            Console.ReadLine();
        }
    }
}