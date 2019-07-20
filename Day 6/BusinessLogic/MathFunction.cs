using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class MathFunction : IMathFunction
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Devide(double x, double y)
        {
            if (y == 0)
            {
                return 0;
            }

            return x / y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Substract(double x, double y)
        {
            return x - y;
        }
    }
}