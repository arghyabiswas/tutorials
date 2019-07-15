using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;

            //int y = x;

            //y = 20;

            //Console.WriteLine(x); // 10


            A x = new A();
            x.Id = 10;

            A y = new A();
            y.Id = x.Id;
            //y = x;

            y.Id = 20;
            Console.WriteLine(x.Id); //

            Console.ReadKey();
        }


        class A
        {
            public int Id;
        }

        struct B
        {
            public int Id;
        }
    }
}
