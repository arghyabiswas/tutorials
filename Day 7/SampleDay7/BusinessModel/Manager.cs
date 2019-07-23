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
        public IEmployee[] Subordinates { get; set; }
    }
}

