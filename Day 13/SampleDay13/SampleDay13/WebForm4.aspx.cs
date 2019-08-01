using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleDay13
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        List<Employee> employees;
        protected void Page_Load(object sender, EventArgs e)
        {
            populateEmployee();

            gvEmployee.DataSource = employees;
            gvEmployee.DataBind();
        }

        private void populateEmployee()
        {
            employees = new List<Employee>();
            employees.Add(new Employee(1)
            {
                Email = "test1@esspl.com",
                Name = "TEST 1",
                Salary = 20000

            });

            employees.Add(new Employee(2)
            {
                Email = "test2@esspl.com",
                Name = "TEST 2",
                Salary = 25000
            });
            employees.Add(new Employee(3)
            {
                Email = "test3@esspl.com",
                Name = "TEST 3",
                Salary = 20000
            });
            employees.Add(new Employee(4)
            {
                Email = "test4@esspl.com",
                Name = "TEST 4",
                Salary = 50000,
                IsManager = true
            });
            employees.Add(new Employee(5)
            {
                Email = "test5@esspl.com",
                Name = " 5 TEST",
                Salary = 20000
            });
        }
        protected void gvEmployee_Sorting(object sender, GridViewSortEventArgs e)
        {

        }
    }
}