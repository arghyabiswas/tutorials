using EmployeeModel.BusinessLogic.Classes;
using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2B
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating list named employee that takes entries of type IEmployee
            List<IEmployee> employee = new List<IEmployee>();

            

            //entering value of employee 1 who is a manager as well 
            IEmployee employee1 = new Manager(1)
            {

                Name = "Test Manager1",
                Email = "manager1@esspl.com"
            };

            //entering details for employee 2
            IEmployee employee2 = new Manager(2);
            employee2.Name = "Test Manager2";
            employee2.Email = "manager2@esspl.com";

            employee.Add(employee1);
            employee.Add(employee2);

           



            IEmployee employee3 = new Employee(3);
            employee3.Name = "Employee 3";
            employee3.Email = "employee3@esspl.com";
            employee3.ReportingManager = employee1;

            IEmployee employee4 = new Employee(4);
            employee4.Name = "Employee 4";
            employee4.Email = "employee4@esspl.com";
            employee4.ReportingManager = employee2;

            IEmployee employee5 = new Employee(5);
            employee5.Name = "Employee 5";
            employee5.Email = "employee5@esspl.com";
            employee5.ReportingManager = employee1;

            IEmployee employee6 = new Employee(6);
            employee6.Name = "Employee 6";
            employee6.Email = "employee6@esspl.com";
            employee6.ReportingManager = employee2;

            IEmployee employee7 = new Employee(7)

            {
                Name = "Employee 4",
                Email = "employee4@esspl.com",
                ReportingManager = employee1
            };


            IEmployee employee8= new Employee(8)

            {
                Name = "Employee 8",
                Email = "employee8@esspl.com",
                ReportingManager = employee1
            };

            IEmployee employee9 = new Employee(9)

            {
                Name = "Employee 9",
                Email = "employee9@esspl.com",
                ReportingManager = employee1
            };

            IEmployee employee10 = new Employee(10)

            {
                Name = "Employee 10",
                Email = "employee10@esspl.com",
                ReportingManager = employee2
            };

            IEmployee employee11 = new Employee(11)

            {
                Name = "Employee 11",
                Email = "employee4@esspl.com",
                ReportingManager = employee2
            };

            IEmployee employee12 = new Employee(12)

            {
                Name = "Employee 12",
                Email = "employee12@esspl.com",
                ReportingManager = employee2
            };

            employee.Add(employee3);
            employee.Add(employee4);
            employee.Add(employee5);
            employee.Add(employee6);
            employee.Add(employee7);
            employee.Add(employee8);
            employee.Add(employee9);
            employee.Add(employee10);
            employee.Add(employee11);
            employee.Add(employee12);


            // creating a variable called subordinates , using LINQ calling the name of employee in list created with manager as employee1

            var subordinates = from name in employee
                               where name.ReportingManager != null && name.ReportingManager.EmployeeId == 1
                               select name ;


            // print statement for the employees called under the above query using a foreach loop with item as temp variable


            Console.WriteLine("Employees under manager1");
            foreach(var item in subordinates)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("Employees under manager2");

            // variable subordinate2 created to find employee with manager as manager2 using expression statements 
            var subordinate2 = employee
                                    .Where(t => t.ReportingManager != null && t.ReportingManager.EmployeeId == 2);

            //foreach loop to print required names 

            foreach (var item in subordinate2)
            {
                Console.WriteLine(item.Name);
            }


            // using count length to count the number of employees in the created list of employees with datatype IEmployee

            Console.WriteLine("The number of employees in the organisation is " + employee.Count);

            Console.ReadKey();




          
        }
    }
}
