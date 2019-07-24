using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    /// <summary>
    /// IManager interface inherit from IEmployee interface
    /// </summary>
    public interface IManager : IEmployee
    {
        IEmployee[] subordinates { get; set; }
    }
}
