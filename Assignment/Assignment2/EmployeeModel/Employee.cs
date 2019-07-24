using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public class Employee : IEmployee
    {
//        private int id;

        public Employee(int Id)
        {
            this.Id = Id;
        }
        public string Email
        {
            get;

            set;
        }

        public int Id
        {
            get;

        }

        public IEmployee Manager
        {
            get;

            set;
        }

        public string Name
        {
            get;

            set;
        }
    }
}
    
    
        
