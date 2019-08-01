using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeModel;

namespace Assignment_5.Sample
{
    public partial class Assignment7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                dropdownemp.DataSource = DataContext.Employees;
                dropdownemp.DataTextField = "name";
                dropdownemp.DataValueField = "employeeId";
                dropdownemp.DataBind();
                dropdownemp.Items.Insert(0, new ListItem("--Select--", ""));
            }

        }

        protected void dropdownemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = dropdownemp.SelectedItem.Text;
            if (selectedItem == "Test Manager1" || selectedItem == "Test Manager2")
            {
                List<IEmployee> employee = DataContext.Employees;
                var employeeDetails = employee.Find(m => m.name == selectedItem);
                ViewState["SelectedEmployee"] = employeeDetails;
                Server.Transfer("EmployeeDetails.aspx");
                //ViewState.Remove;
            }
            else
            {
                List<IEmployee> employee = DataContext.Employees;
                var employeeDetails = employee.Find(m => m.name == selectedItem);
                Session["SelectedEmployee"] = employeeDetails;
                Response.Redirect("EmployeeDetails.aspx");
                
            }
            
        }
    }
}