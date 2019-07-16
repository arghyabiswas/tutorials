using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureSample
{
    public struct Employee
    {
        int id;
        int zipcode;
        double salary;
        // all the members of the struct has to be initialized in this way  
        public Employee(int id, int zipcode, double salary)
        {
            this.id = id;
            this.zipcode = zipcode;
            this.salary = salary;
        }
        // all the members of the struct has to be initialized either in this way  
        public Employee(int id, int zipcode)
        {
            this.id = id;
            this.zipcode = zipcode;
            this.salary = 3400.00;
        }

        // struct can also have copy constructor but have to be fully initialzed  
        public Employee(Employee x)
        {
            this.id = x.id;
            this.zipcode = x.zipcode;
            this.salary = x.salary;
        }

        public void DisplayValues()
        {
            Console.WriteLine("ID: " + this.id.ToString());
            Console.WriteLine("Zipcode : " + this.zipcode.ToString());
            Console.WriteLine("Salary : " + this.salary.ToString());
        }
    }
}
