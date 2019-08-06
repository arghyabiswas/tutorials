using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessModel;

namespace Assignment5
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SelectedEmployee"] != null)
            {
                var data = (IEmployee)Session["SelectedEmployee"];
                Label1.Text = data.Name;
                Label2.Text = data.Email;
                Label3.Text = Convert.ToString(data.EmployeeId);
                Label4.Text = data.ReportingManager.Name;
    
            }

        }
    }
}