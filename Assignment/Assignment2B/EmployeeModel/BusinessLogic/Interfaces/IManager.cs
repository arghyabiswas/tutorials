using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel.BusinessLogic.Interfaces
{
    public interface IManager : IEmployee
    {
        /// <summary>
        /// Property to write and read Subordinate for manager.
        /// </summary>
        IEmployee[] Subordinates { get; set; }

    }
}
