using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Sample
{
    public partial class Assignment7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListEmployee.DataSource = DataContext.employees;
                DropDownListEmployee.DataTextField = "Name";
                DropDownListEmployee.DataValueField = "EmployeeId";

                DropDownListEmployee.DataBind();

                DropDownListEmployee.Items.Insert(0, new ListItem("--Select Employee name--", ""));
            }
        }

        protected void DropDownListEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(DropDownListEmployee.SelectedItem.Value);
            var EmployDetails = DataContext.employees;
            var employee = EmployDetails.FirstOrDefault(p => p.EmployeeId == x);

            if (employee.EmployeeId == 13 || employee.EmployeeId == 14)
            {
                ViewState["SelectedEmployee"] = employee;
            }
            else
            {
                Session["SelectedEmployee"] = employee;
            }
        }
    }
}