using EmployeeModel.BusinessLogic.Classes;
using EmployeeModel.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;

namespace Assignment_8.Sample
{
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var employeeData = (List<IEmployee>)Session["SelectedEmployee"];
            GridViewEmployeeData.DataSource= employeeData;
            GridViewEmployeeData.DataBind();
        }

        protected void ButtonReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("assignment8.aspx");
        }
    }
}