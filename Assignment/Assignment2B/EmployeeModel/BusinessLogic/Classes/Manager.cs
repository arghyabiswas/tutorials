using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel.BusinessLogic.Classes
{
    public class Manager : Employee, IManager
    {
        
        public Manager(int EmployeeId ):base(EmployeeId)
        {
            
        }

        public IEmployee[] Subordinates { get; set; }



    }
}
