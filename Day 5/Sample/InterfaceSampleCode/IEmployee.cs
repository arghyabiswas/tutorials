using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSampleCode
{

    public interface IEmployee
    {
        // No public or private
        string FirstName { get; set; }

        string LastName { get; set; }

        void printFullName();

    }
}
