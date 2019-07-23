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
            IEmployee[] employees = new IEmployee[3];

            employees[0] = new Manager(1);
            employees[0].name = "Nikolas";
            employees[0].email = "manager@esspl.com";

            employees[1] = new Employee(2);
            employees[1].name = "Deepak";
            employees[1].email = "deepak@esspl.com";
            employees[1].ReportingManager = employees[0];

            employees[2] = new Employee(2);
            employees[2].name = "Bishal";
            employees[2].email = "bishal@esspl.com";
            employees[2].ReportingManager = employees[0];

            //for(int i=1;i<3;i++)
            //{
            //    Console.WriteLine("Manager Email : {0}  No Of Emp :{1}", employees[0].email, count(employees[i]));
            //}
            

            for (int i=1;i<3;i++)
            {
                Console.WriteLine("Employee Name : {0} Email  :{1} Reporting Manager Name : {2}", 
                    employees[i].name, employees[i].email, employees[i].ReportingManager.name);
            }

            Console.ReadLine();
        }
    }
}
