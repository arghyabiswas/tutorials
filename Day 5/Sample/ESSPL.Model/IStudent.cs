using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESSPL.Model
{
    public interface IStudent
    {
        int Id { get; }

        string FirstName { get; set; }

        string LastName { get; set; }

    }
}
