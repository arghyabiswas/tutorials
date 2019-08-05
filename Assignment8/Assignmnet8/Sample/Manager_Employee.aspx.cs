using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignmnet8.Sample
{
    public partial class Manager_Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          var employeeData = (List<IEmployee>)Session["SelectedEmployee"];
            GridViewEmp.DataSource = employeeData;
            GridViewEmp.DataBind();
        }

        
    }
}