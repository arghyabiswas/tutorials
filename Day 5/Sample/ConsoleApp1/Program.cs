using StructureSample;
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
            //int x = 10;

            //int y = x;
            //y = 20;

            //Console.WriteLine(x);

            Employee employee1 = new Employee(1,1234567,300000);

            Employee employee2 = new Employee(employee1);

            Console.ReadKey();
        }
    }


    //struct Employee
    //{
    //    string firstName;
    //    string lastName;

    //    public Employee(string firstName, string lastName)
    //    {
    //        this.firstName = firstName;
    //        this.lastName = lastName;
    //    }
    //}
}
