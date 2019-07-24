using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    interface IManager : IEmployee
    {
        
        IEmployee [] subordinate { get; set; }

    }
}
