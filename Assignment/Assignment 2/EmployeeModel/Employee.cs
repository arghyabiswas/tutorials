using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    // employee class which implements Interface Iemployee and inherits class manager
    public class Employee : Iemployee, Manager 
    {


        public Employee(int employeeid)
        {
            this.employeeid = employeeid;
        }

        public string Email { get; set; }


        public int id { get; }


        public string Name { get; set; }


        public Iemployee ReportingManager { get; set; }


    }
}
}
