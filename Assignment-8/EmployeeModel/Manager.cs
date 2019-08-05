using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Manager : Employee, IManager
    {
        public IEmployee[] SubOrdinates
        {
            get;
            set;          
        }

        public Manager(int employeeId): base(employeeId)
        {
            
        }
    }
}
