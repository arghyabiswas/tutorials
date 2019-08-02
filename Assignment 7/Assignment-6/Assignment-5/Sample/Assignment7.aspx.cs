using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Assignment_5.Sample
{
    public partial class Assignment7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                dropdown.DataSource = DataContext.employees;
                dropdown.DataTextField = "Name";
                dropdown.DataValueField = "Employeeid";
                dropdown.DataBind();
                dropdown.Items.Insert(0, new ListItem("-----select-----", ""));
            }

        }

        protected void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdown.SelectedItem.Text == "Test Manager 1" || dropdown.SelectedItem.Text == "Test Manager 2")
            {

                List<IEmployee> employee = DataContext.employees;
                var Employeedetails = employee.Where(p => p.Name == dropdown.SelectedItem.Text);
                ViewState["SelectedEmployee"] = Employeedetails;

                Server.Transfer("EmployeeDetails.aspx");
            }

            else
            {
                List<IEmployee> employee = DataContext.employees;
                var Employeedetails = employee.Find(m => m.Name == dropdown.SelectedItem.Text);
                Session["SelectedEmployee"] = Employeedetails;

                Response.Redirect("EmployeeDetails.aspx");



            }
        }
    }
}