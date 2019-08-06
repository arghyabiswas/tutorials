using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    /// <summary>
    /// Interface Manager implements from Employee Interface
    /// </summary>
    public interface IManager : IEmployee
    {
        IEmployee[] SubOrdinates { get; set; }
    }
}
