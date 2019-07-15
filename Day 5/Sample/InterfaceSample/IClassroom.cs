using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSample
{
    public interface IClassroom
    {
        IStedent[] Students { get; set; }
    }
}
