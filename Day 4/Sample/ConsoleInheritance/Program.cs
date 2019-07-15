using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //((ParmanentEmployee)employee).printFullName();

            //ParmanentEmployee parmanentEmployee = new ParmanentEmployee("ESSPPL", "Employee");
            //((Employee)parmanentEmployee).printFullName();

            //TemporaryEmployee temporaryEmployee = new TemporaryEmployee();

            Employee temporaryEmployee = new TemporaryEmployee();

            temporaryEmployee.FirstName = "ESSPL";

            //temporaryEmployee.salary = -30000;
            //temporaryEmployee.firstName = "";

            temporaryEmployee.printFullName();

            Console.ReadKey();
        }
    }
}
