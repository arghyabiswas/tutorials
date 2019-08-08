using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MsAjaxTutorial.Sample.UserControls
{
    public partial class AddEmployee : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlManager.DataSource = DataContext.Employees
                                                    .Where(p => p is IManager)
                                                    .ToList();

                ddlManager.DataValueField = "EmployeeId";
                ddlManager.DataTextField = "Name";
                ddlManager.DataBind();

                ddlManager.Items.Insert(0, new ListItem("--Select Manager--", ""));
            }
        }

        public void AddNewEmployee()
        {
            int totalEmploy = DataContext.Employees.Count;
            IEmployee newEmployee = new Employee(totalEmploy + 1);
            newEmployee.Name = txtName.Text;
            newEmployee.Email = txtEmail.Text;

            IEmployee manager = DataContext.Employees
                                .FirstOrDefault(p => p.EmployeeId == Convert.ToInt32(ddlManager.SelectedValue));

            newEmployee.ReportingManager = manager;
            ((IManager)manager).Subordinates.Add(newEmployee);

            DataContext.Employees.Add(newEmployee);
        }
    }
}