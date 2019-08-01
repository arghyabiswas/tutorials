using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignmnet8.Sample
{
    public partial class assignment8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var employee = DataContextEmp.Employees1.Where(m => m.ReportingManager == null).ToList();
                dropdownmgr.DataSource = employee;
                dropdownmgr.DataTextField = "name";
                dropdownmgr.DataValueField = "employeeId";
                dropdownmgr.DataBind();
                dropdownmgr.Items.Insert(0, new ListItem("----Select Manager----", ""));
            }
        }

        protected void dropdownemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = Convert.ToInt32(dropdownmgr.SelectedItem.Value);

            var employee = DataContextEmp.Employees1
                            .Where(m => m.ReportingManager != null && m.ReportingManager.employeeId == selectedItem)
                            .ToList();
            Session["SelectedEmployee"] = employee;
            Response.Redirect("Manager_Employee.aspx");

        }
    }
}