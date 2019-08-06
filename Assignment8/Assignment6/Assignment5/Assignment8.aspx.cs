using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessModel;

namespace Assignment5
{
    public partial class Assignment8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List < Employee > EmpList = new List<Employee>();
            EmpList.Add(new Employee(1)
            {
                Name="Manager1", Email="manager1@gmail.com"
        });
            EmpList.Add(new Employee(2)
            {
                Name = "Manager2",
                Email = "manager2@gmail.com"
            });
            if (!IsPostBack)
            {
                DropDownListManager.DataSource = EmpList;
                DropDownListManager.DataTextField = "Name";
                DropDownListManager.DataValueField = "EmployeeId";
                DropDownListManager.DataBind();
                DropDownListManager.Items.Insert(0, new ListItem("------Select Manager------", ""));
            }
            
        }

        protected void DropDownListManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IEmployee> Emp = DataContext.Employees;
            var emp = Emp.Where(p => p.ReportingManager != null && p.ReportingManager.Name == DropDownListManager.SelectedItem.Text).ToList();

            Session["EmployeesDetails"] = emp;

            Response.Redirect("GridView.aspx");
        }
    }
}