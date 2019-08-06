using BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5
{
    public partial class GridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var emp = (List<IEmployee>)Session["EmployeesDetails"];
            GridView1.DataSource = emp;
            GridView1.DataBind();

        }
    }
}