using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Sample
{
    public partial class Assignment8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<IEmployee> employee = DataContext.employees
                                                     .Where(m => m.ReportingManager == null)
                                                     .ToList();
                DropDownListManager.DataSource = employee;
                DropDownListManager.DataTextField = "Name";
                DropDownListManager.DataValueField = "EmployeeId";
                DropDownListManager.DataBind();
                DropDownListManager.Items.Insert(0, new ListItem("--Select Manager--", ""));
            }

        }

        protected void DropDownListManager_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (DropDownListManager.SelectedItem.Value != string.Empty)
            {
                int selectedItem = Convert.ToInt32(DropDownListManager.SelectedItem.Value);

                List<IEmployee> employee = DataContext.employees
                                  .Where(m => m.ReportingManager != null && m.ReportingManager.EmployeeId == selectedItem)
                                  .ToList();

                Session["SelectedEmployee"] = employee;
                Response.Redirect("EmployeeDetails.aspx");

            }
        }
    }
}