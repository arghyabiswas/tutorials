using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Sample
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var employeeData = (List<IEmployee>)Session["SelectedEmployee"];
            GridViewEmployeeData.DataSource = employeeData;
            GridViewEmployeeData.DataBind();
        }

        protected void ButtonReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Assignment8.aspx");
        }
    }

}