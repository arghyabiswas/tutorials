using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    [Serializable]
    public class Manager : Employee, IManager
    {
        public IEmployee[] subordinate { get; set; }

        public Manager(int id) : base(id)
        {
         
        }

    }
}
