using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Manager : Employee, IManager
    {
        public Manager(int Id) : base(Id)  {

        }
        public IEmployee[] subordinates
        {
            get;
            set;
        }
    }
}
