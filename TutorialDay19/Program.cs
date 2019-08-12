using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TutorialDay19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataInsert di = new DataInsert();
            DisplayTable dt = new DisplayTable();
            Console.WriteLine("----------Select action-------------");
            Console.WriteLine("1. Insert records");
            Console.WriteLine("2. View records");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice: ");
            int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        di.InserttoDB();
                        break;
                    case 2:
                        dt.Display();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice !!");
                        break;
                }

        }

    }
}
