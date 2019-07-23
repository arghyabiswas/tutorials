using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class Manager : Employee,IManager
    {
        /// <summary>
        /// Create a constructor of Manager class 
        /// </summary>
        /// <param name="employeeid"></param>
        public Manager(int employeeid):base(employeeid)
        {

        }
        public IEmployee[] subordinates { get; set; }
    }
}
