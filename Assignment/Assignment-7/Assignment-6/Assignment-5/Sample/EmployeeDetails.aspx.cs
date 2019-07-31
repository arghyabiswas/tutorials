using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5.Sample
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SelectedEmployee"] != null)
            {
                dynamic data = (IEmployee)Session["SelectedEmployee"];
                Label1.Text = data.name;
                Label2.Text = data.email;
                Label3.Text = Convert.ToString(data.employeeId);
                Label4.Text = data.ReportingManager.name;
                Session.Abandon();
            }
        }
    }
}