using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EmployeeModel
{
    /// <summary>
    /// Interface of Employee having following Properties
    /// </summary>
    public interface IEmployee
    {
        int employeeId { get; }
        String name { get; set; }
        string email { get; set; }

        IEmployee ReportingManager { get; set; }
    }
}
