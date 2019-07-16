using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppRefandOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            string email;

            //bool isValid = employee.Validate(123, ref email);


            bool isValid2 = employee.Validate2(123, out email);

            Console.WriteLine(email);

            Console.ReadKey();
        }
    }


    class Employee
    {
       
        public bool Validate(int id, ref string email)
        {
            email = "employee@esspl.com";

            return true;
        }

        public bool Validate2(int id, out string email)
        {
            email = "employee@esspl.com";

            return true;
        }
    }
}
