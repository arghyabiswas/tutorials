using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2InterfaceWithSameMethodName
{
    class Program
    {
        static void Main(string[] args)
        {
            // IInteger integer = new MathOperation();

            //integer.Add(2,3);

            IDouble d = new MathOperation();
            d.Add(2, 3);

            Console.ReadKey();
        }
    }

    class MathOperation : MathOperationBase, IInteger, IDouble
    {
        public override void Test()
        {
            // DO NOTHING
        }

        int IInteger.Add(int x, int y)
        {
            Console.WriteLine("IInteger Add");

            return x + y;
        }

        double IDouble.Add(double x, double y)
        {
            Console.WriteLine("IDouble double Add");
            return x + y;
        }

        int IDouble.Add(int x, int y)
        {
            Console.WriteLine("IDouble int Add");
            return x + y;
        }
    }

    internal abstract class MathOperationBase : IInteger, IDouble
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public double Add(double x, double y)
        {
            return x + y;
                    }

       public abstract void Test();
    }
    interface IInteger
    {
        int Add(int x, int y);
    }


    interface IDouble
    {
        double Add(double x, double y);
        int Add(int x, int y);
    }


    class TestReadonly
    {
        public readonly string name;

        public const string LAST_NAME = "TEST";

        public readonly MathOperation math;
        public TestReadonly()
        {
            name = "ESSPL";
            math = new MathOperation();
        }


        public void Test()
        {
            //name = "Test";
        }

    }



    // A function will return an integer and a bool;

    class Test
    {
        readonly
        public int Id { get; set; }

        public bool IsValid { get; set; }



        public bool Validate(int id,ref string email)
        {


            return true;
        }
    }


}
