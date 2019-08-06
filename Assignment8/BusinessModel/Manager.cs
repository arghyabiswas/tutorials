using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class Manager : Employee, Imanager//class inherting Employee and implimenting Imanager
    {
        public Manager(int EmployeeId): base(EmployeeId) { }//first constructor is being created for child class then for child class
        public IEmployee[] Subordinates { get; set; }//subordinates array of IEmployee type 
        
    }
}
