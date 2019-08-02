using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5
{
    public partial class DetailsEmployeeUnderManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmployeesDetails"] != null)
            {
                var Emp1 = (List<IEmployee>)Session["EmployeesDetails"];
                GridView1.DataSource = Emp1;
                GridView1.DataBind();
            }
            else
            {
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Assignment 8.aspx");
        }
    }
}