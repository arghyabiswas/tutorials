using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class Employee : IEmployee
    {
        public Employee()
        {
        }

        public Employee(int id)
        {
            this.Id = id;
        }

        public int Id { get; }

        public string Name { get; set; }
        public string Email { get; set; }
        public IEmployee ReportingManager { get; set; }

        public IEmployee Copy()
        {
            IEmployee newEmployee = new Employee(this.Id);
            newEmployee.Name = this.Name;
            newEmployee.Email = this.Email;
            newEmployee.ReportingManager = this.ReportingManager.Copy();

            return newEmployee;
        }
    }
}
