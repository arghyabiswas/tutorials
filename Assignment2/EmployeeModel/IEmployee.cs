using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
   public interface IEmployee
    {
        //(2.a)
        int EmployeeId { get; } //restrict this to be read-only outside interface
        string Name { get; set; }
        string Email { get; set; }
        IEmployee ReportingManager { get; set; } //reference var
    }
}
