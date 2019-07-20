using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Tutorial
{
    class Program
    {
        //Simple delegate
        public delegate double ExecuteMathOperation(double x, double y);
        public delegate void LogHandler(string message);

        
        static void Main(string[] args)
        {
            IMathFunction mathFunction = new MathFunction();

            ExecuteMathOperation executeMathOperation;


            Console.WriteLine("We are going to perform mathematical operation:");




            while (true)
            {


                Console.WriteLine("Allowed keys are:");
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("*");
                Console.WriteLine("/");
                Console.WriteLine("Use an other key to exit");

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.KeyChar)
                {
                    case '+':
                        executeMathOperation = new ExecuteMathOperation(mathFunction.Add);
                        break;

                    case '-':
                        executeMathOperation = new ExecuteMathOperation(mathFunction.Substract);
                        break;

                    case '*':
                        executeMathOperation = new ExecuteMathOperation(mathFunction.Multiply);
                        break;

                    case '/':
                        executeMathOperation = new ExecuteMathOperation(mathFunction.Devide);
                        break;


                    default:
                        return;
                }


                Console.WriteLine("First number:");
                string firsrNUmber = Console.ReadLine();
                double numericFirstNumber = Convert.ToDouble(firsrNUmber);

                Console.WriteLine("Second number:");
                string secondNUmber = Console.ReadLine();
                double numericSecondNumber = Convert.ToDouble(secondNUmber);

                Console.WriteLine("Result: {0}", executeMathOperation(numericFirstNumber, numericSecondNumber));
            }


        }


        //Calling Static function
        /*
        static void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {

            LogHandler logHandler = new LogHandler(LogToConsole);
            logHandler("Sample Log");
            Console.ReadKey();
        }

        */

        //Multicust delegate

        /*
        static void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }

        static void LogToFile(string message)
        {
            message = string.Format("{0}:{1}", DateTime.Now, message);
            using (System.IO.StreamWriter file = 
                new System.IO.StreamWriter(string.Format(@"{0}\log.txt", Environment.CurrentDirectory),true))
            {
                file.WriteLine(message);
            }
        }

        static void Main(string[] args)
        {
            LogHandler logHandler = null;
            logHandler += LogToConsole;
            logHandler += LogToFile;

            logHandler("Sample Log");
            Console.ReadKey();
        }

        */

        //simple event
        /*
        static void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }

        static void LogToFile(string message)
        {
            message = string.Format("{0}:{1}", DateTime.Now, message);
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(string.Format(@"{0}\log.txt", Environment.CurrentDirectory), true))
            {
                file.WriteLine(message);
            }
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            // Subscribe the Functions Logger and fl.Logger
            employee.Log += new Employee.LogHandler(LogToConsole);
            employee.Log += new Employee.LogHandler(LogToFile);
            employee.Login();
            Console.ReadKey();
        }
        */

        //time event

        /*
        public static void Main()
        {
            // Create a new clock
            Clock theClock = new Clock();

            // Create the display and tell it to
            // subscribe to the clock just created
            DisplayClock dc = new DisplayClock();
            dc.Subscribe(theClock);

            // Create a Log object and tell it
            // to subscribe to the clock
            LogClock lc = new LogClock();
            lc.Subscribe(theClock);

            // Get the clock started
            theClock.Run();
        }

        */
    }
}
