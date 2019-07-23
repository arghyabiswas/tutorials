using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
   public class Manager:Employee,IEmployee
    {
        public Manager(int EmployeeId) : base(EmployeeId) { }//base class constructor needs to be initialised first
        public IEmployee[] Subordinates { get; set; }
    }
}
