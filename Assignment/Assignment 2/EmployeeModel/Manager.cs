using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   {
   public class Manager : Employee, Imanager
    {
        public Manager(int employeeid) : base(employeeid)
        {


        }
        public Iemployee[] Subordinates { get; set; }

    }
}

}
