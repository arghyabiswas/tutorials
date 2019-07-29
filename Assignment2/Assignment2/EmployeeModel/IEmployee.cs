using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public interface IEmployee
    {
         int employeeid { get; }
         string name { get; set; }
         string email { get; set; }
        IEmployee reportingmanager { get; set; }
    }
}
