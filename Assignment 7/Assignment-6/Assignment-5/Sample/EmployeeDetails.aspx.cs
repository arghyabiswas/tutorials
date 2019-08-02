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
                var Emp = (IEmployee)Session["SelectedEmployee"];
                Label.Text = Convert.ToString(Emp.EmployeeId);
                Label1.Text = Emp.Name;
                Label2.Text = Emp.Email;
                Label3.Text = Convert.ToString(Emp.ReportingManager.Name);
                Session.Abandon();
            }
        }
    }
}