using ESSPL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESSPL.BusinessLogic
{
    public class Student : IStudent
    {
        public int Id { get; set; }

        /*******************************/

        /*
        public void setId(int id)
        {

        }

        public int getId()
        {

        }
        */

        /**********************************/

        public string FirstName { get; set; }
        public string LastName { get; set; }


        // Communicate with Database
    }
}
