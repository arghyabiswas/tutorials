using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
   public interface IEmployee
    {
        int EmployeeId { get; }//read only access restriction
        string name { get; set; }
        string email { get; set; }
        IEmployee ReportingManager { get; set; }
    }
}
