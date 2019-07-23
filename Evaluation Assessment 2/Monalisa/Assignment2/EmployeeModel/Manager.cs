using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Manager : Employee, IManager
    {

        public Manager(int EmpID): base(EmpID) { }//(2.d)Parent class constructor created first then for the child class
        public IEmployee[] Subordinates { get; set; }
       
    }
}
