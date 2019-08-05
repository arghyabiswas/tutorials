using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Manager : Employee, IManager
    {
        public IEmployee[] subordinate { get; set; }

        public Manager(int id) : base(id)
        {
         
        }

    }
}
