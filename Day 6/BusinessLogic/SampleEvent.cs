
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Employee
    {
        // Define a delegate named LogHandler
        public delegate void LogHandler(string message);

        // Define an Event based on the above Delegate
        public event LogHandler Log;


        // Instead of having the Process() function take a delegate
        public void Login()
        {
            if (Log != null)
            {
                Log("Process() begin");
            }


            //Login operation
            Console.WriteLine("Login Success");

            if (Log != null)
            {
                Log("Process() end");
            }
        }



    }
}
