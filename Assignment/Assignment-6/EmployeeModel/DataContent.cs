﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModel
{
    public static class DataContext
    {
        static DataContext()
        {

            Employees = new List<IEmployee>();

        }
        public static List<IEmployee> Employees { get; private set; }
    }

}