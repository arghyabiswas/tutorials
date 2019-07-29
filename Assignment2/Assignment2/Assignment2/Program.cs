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
            IEmployee[] iemployee = new IEmployee[3]; 
            IEmployee manager = new Manager(1);

            iemployee[0] = new Manager(1);
            iemployee[0].name = "Manager1";
            iemployee[0].email = "manager1@esspl.com";
        
            iemployee[1] = new Employee(1);
            iemployee[1].name = "Employee1";
            iemployee[1].reportingmanager = iemployee[0];
            iemployee[1].email = "emp1@gmail.com";

            iemployee[2] = new Employee(2);
            iemployee[2].name = "Employee2";
            iemployee[2].reportingmanager = iemployee[0];
            iemployee[2].email = "emp2@gmail.com";

            Console.WriteLine("Employee name:"+iemployee[1].name + " Email:" + iemployee[1].email + " Reporting manager:" + iemployee[1].reportingmanager.name);
            Console.WriteLine();
            Console.WriteLine("Employee name:" + iemployee[2].name + " Email:" + iemployee[2].email + " Reporting manager:" + iemployee[2].reportingmanager.name);
            Console.ReadKey();
        }
    }
}
