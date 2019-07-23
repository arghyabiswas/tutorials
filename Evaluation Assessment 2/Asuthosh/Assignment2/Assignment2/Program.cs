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
            IEmployee[] emp = new IEmployee[3];//array of IEmployee objects


            emp[0] = new Manager(1);
            emp[1] = new Employee(1);
            emp[2] = new Employee(2);


            emp[0].email = "ashutoshd@esspl.com";
            emp[0].name = "Ashutosh Dash";


            emp[1].email = "monalisa@esspl.com";
            emp[1].name = "Monalisa";
            emp[1].ReportingManager = emp[0];


            emp[2].email = "aseem@esspl.com";
            emp[2].name = "aseem";
            emp[2].ReportingManager = emp[0];

            

            for (int i = 0; i <= 2; i++)//loop to print employee name , email and manager name
            {
                Console.WriteLine("Name:{0}, Email:{1}, ManagerName:{2}", emp[i].name, emp[i].email, emp[0].name);
            }
            Console.ReadKey();




        }
    }
}
