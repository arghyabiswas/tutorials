using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSampleCode
{
    public class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Salary { get; set; }

        public void printFullName()
        {
            Console.WriteLine("{0} {1}", FirstName, LastName);
        }
    }

}
