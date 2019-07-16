using InterfaceSampleCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterfaceCalling
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee employee = new Employee();//Error new IEmployee();
            
            employee.printFullName();
            Console.ReadKey();
        }
    }
}
