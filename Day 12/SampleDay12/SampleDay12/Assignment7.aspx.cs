using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleDay12
{
    public partial class Assignment7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

            ddlEmployee.DataSource = DataContext.Employees;
            ddlEmployee.DataTextField = "Name";
            ddlEmployee.DataValueField = "Employeeid";

            ddlEmployee.DataBind();
            ddlEmployee.Items.Insert(0, new ListItem("--Select--", ""));
        }

        protected void ddlEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(ddlEmployee.SelectedValue);

            IEmployee employees = DataContext.Employees
                                  .FirstOrDefault(p => p.Employeeid == employeeId);

            if(employees.ReportingManager == null)// Manager
            {

            }
            else// Not Manager
            {

            }

        }
    }
}