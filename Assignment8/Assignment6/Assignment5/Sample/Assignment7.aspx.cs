using BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5.Sample
{
    public partial class Assignment7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Employees.DataSource = DataContext.Employees;
                Employees.DataTextField = "Name";
                Employees.DataValueField = "EmployeeId";

                Employees.DataBind();
                Employees.Items.Insert(0, new ListItem("--Select Employee--", ""));

            }
        }

        protected void Employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = Employees.SelectedItem.Text;
            if (selectedItem == "Test Manager1" || selectedItem == "Test Manager2")
            {
                List<IEmployee> employee = DataContext.Employees;
                var employeeDetails = employee.Find(m => m.Name == selectedItem);
                ViewState["SelectedEmployee"] = employeeDetails;
                Server.Transfer("/EmployeeDetails.aspx");
                //ViewState.Remove;
            }
            else
            {
                List<IEmployee> employee = DataContext.Employees;
                var employeeDetails = employee.Find(m => m.Name == selectedItem);
                Session["SelectedEmployee"] = employeeDetails;
                Response.Redirect("/EmployeeDetails.aspx");

            }

        }
            }
        }
