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
            IEmployee[] arr = new IEmployee[3];//(3.a)array of length 3 of the type IEmployee

            arr[0] = new Manager(1); //(3.b)object for manager under array position 0
            arr[0].Email = "monalisa@esspl.com";//inserting the values by object 
            arr[0].Name = "Monalisa Moharana\n";//inserting the values by object 



            arr[1] = new Employee(2);//(3.c)two objects for employee under array position 1 and 2
            arr[1].Email = "rayaseem@gmail.com";//inserting the values by object 
            arr[1].Name = "Aseem Ray\n";//inserting the values by object 
            arr[1].ReportingManager = arr[0];//giving the reference


            arr[2] = new Employee(3);
            arr[2].Email = "ashutosh@esspl.com";//inserting the values by object 
            arr[2].Name = "Ashutosh Dash\n";//inserting the values by object 
            arr[2].ReportingManager = arr[0];//giving the reference
            for (int i = 0; i <= 2; i++)//initialising a for loop for printing from arr[0]-arr[2]
            {
                Console.WriteLine("Name:{0}, Email:{1}, ManagerName:{2}", arr[i].Name, arr[i].Email, arr[0].Name);//printing all the details 
                //printing all the required details 
            }
            Console.ReadKey();
        }
    }
}
