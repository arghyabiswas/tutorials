using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    /// <summary>
    /// Structure of the manager
    /// </summary>
    public interface IManager : IEmployee
    {
        /// <summary>
        /// Collection of employee under the manager
        /// </summary>
        List<IEmployee> Subordinates { get; set; }
    }
}
