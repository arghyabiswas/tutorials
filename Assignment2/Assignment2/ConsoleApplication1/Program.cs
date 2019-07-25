using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee[] arr = new IEmployee[3];//creation and size declaration of array


            arr[0] = new Manager(1);//creation of object 


            arr[0].Email = "rayaseem@gmail.com";//storing value by object
            arr[0].Name = "Aseem Ray";//storing value by object



            arr[1] = new Employee(2);//creation of object 
            arr[1].Email = "anynomyous@gmail.com";//storing value by object
            arr[1].Name = "Ashutosh Dash";//storing value by object
            arr[1].ReportingManager = arr[0];//referencing with arr[0]


            arr[2] = new Employee(3);//creation of object 
            arr[2].Email = "rayaseem@gmail.com";//storing value by object
            arr[2].Name = "Aseem Ray";//storing value by object
            arr[2].ReportingManager = arr[0];//referencing with arr[0]
            for (int i = 0; i <= 2; i++)//initialising a for loop for running from arr[0]-arr[2]
            {
                Console.WriteLine("Name:{0}, Email:{1}, ManagerName:{2}", arr[i].Name, arr[i].Email, arr[0].Name);
                //printig all details 
            }
            Console.ReadKey();//To hold the screen




        }
    }
}
