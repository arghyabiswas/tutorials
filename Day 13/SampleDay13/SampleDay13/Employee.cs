using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleDay13
{
    public class Employee
    {
        public Employee(int employeeid)
        {
            this.Employeeid = employeeid;
        }
        public string Email
        {
            get; set;
        }

        public int Employeeid
        {
            get;
        }

        public string Name
        {
            get; set;
        }

        public double Salary { get; set; }

        public bool IsManager { get; set; }
        //public IEmployee ReportingManager
        //{
        //    get; set;
        //}

    }
}