using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class Manager : Employee, IManager
    {
        public Manager(int id)
            : base(id)
        {

        }


        /// <summary>
        /// Copy Constructor
        /// </summary>
        /// <param name="employee"></param>
        public Manager(IEmployee employee)
            :base(employee.Id)
        {
            base.Name = employee.Name;
            base.Email = employee.Email;
            base.ReportingManager = base.ReportingManager;
        }

        public IEmployee[] Subordinates { get; set; }
        
    }
}

