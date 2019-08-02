using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_5
{
    public partial class Assignment_8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1)
            {
                Name = "Manager 1",
                Email = "Manager1@esspl.com"
            });
            employees.Add(new Employee(2)
            {
                Name = "Manager 2",
                Email = "Manager2@esspl.com"
            });


            if (!IsPostBack)
            {

                DropDownList1.DataSource = employees;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "Employeeid";
                DropDownList1.DataBind();
                DropDownList1.Items.Insert(0, new ListItem("------Select Manager------", ""));
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IEmployee> Emp = DataContext.Employees;
            var emp = Emp.Where(p => p.ReportingManager != null && p.ReportingManager.Name == DropDownList1.SelectedItem.Text).ToList();

            Session["EmployeesDetails"] = emp;

            Response.Redirect("DetailsEmployeeUnderManager.aspx");

        }
    }
}