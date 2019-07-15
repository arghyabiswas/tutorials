using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public interface IMathFunction
    {
        double Add(double x, double y);

        double Substract(double x, double y);

        double Multiply(double x, double y);

        double Devide(double x, double y);

    }
}
