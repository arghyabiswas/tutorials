using EmployeeModel.BusinessLogic.Classes;
using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_8.Sample
{
    public partial class assignment8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<IEmployee> employee = DataContext.Employees
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



                Session["SelectedEmployeeId"] = selectedItem;
                Response.Redirect("EmployeeDetails.aspx");

            }
        }
    }
}