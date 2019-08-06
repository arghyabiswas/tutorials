using EmployeeModel.BusinessLogic.Classes;
using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_8.Sample
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SelectedEmployeeId"] != null)
            {
                var selectedId = Convert.ToInt32(Session["SelectedEmployeeId"]);

                List<IEmployee> employee = DataContext.Employees
                            .Where(m => m.ReportingManager != null && m.ReportingManager.EmployeeId == selectedId)
                            .ToList();
                GridViewEmployeeData.DataSource = employee;
                GridViewEmployeeData.DataBind();
            }

        }

        protected void ButtonReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("assignment8.aspx");
        }
    }
}