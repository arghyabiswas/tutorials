using EmployeeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MsAjaxTutorial.Sample.UserControls
{
    public partial class EmployeeGrid : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
            }
        }

        /// <summary>
        /// Binding list of employee with the grid view
        /// </summary>
        void BindGrid()
        {
            gvEmployee.DataSource = DataContext.Employees;
            gvEmployee.DataBind();
        }

        /// <summary>
        /// Page index change event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployee_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEmployee.PageIndex = e.NewPageIndex;
            BindGrid();
        }

        /// <summary>
        /// Sorting Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployee_Sorting(object sender, GridViewSortEventArgs e)
        {
            List<IEmployee> employees = DataContext.Employees;

            string lastSortColumnName = Convert.ToString(ViewState["LastSortColumnName"]);

            switch (e.SortExpression)
            {
                case "Name":

                    if (!lastSortColumnName.Equals("Name"))
                    {
                        gvEmployee.DataSource = employees
                            .OrderBy(p => p.Name)
                            .ToList();
                        ViewState["LastSortColumnName"] = e.SortExpression;
                    }
                    else
                    {
                        gvEmployee.DataSource = employees
                            .OrderByDescending(p => p.Name)
                             .ToList();
                        ViewState["LastSortColumnName"] = string.Empty;
                    }
                    break;

                case "Email":
                    if (!lastSortColumnName.Equals("Email"))
                    {
                        gvEmployee.DataSource = employees
                            .OrderBy(p => p.Email)
                             .ToList();
                        ViewState["LastSortColumnName"] = e.SortExpression;
                    }
                    else
                    {
                        gvEmployee.DataSource = employees
                            .OrderByDescending(p => p.Email)
                             .ToList();
                        ViewState["LastSortColumnName"] = string.Empty;
                    }
                    break;

                default:
                    if (!lastSortColumnName.Equals("EmployeeId"))
                    {
                        gvEmployee.DataSource = employees
                            .OrderBy(p => p.EmployeeId)
                             .ToList();
                        ViewState["LastSortColumnName"] = e.SortExpression;
                    }
                    else
                    {
                        gvEmployee.DataSource = employees
                            .OrderByDescending(p => p.EmployeeId)
                             .ToList();
                        ViewState["LastSortColumnName"] = string.Empty;
                    }
                    break;
            }


            gvEmployee.DataBind();

        }

        /// <summary>
        /// Clicking event of Edit button under CommandField
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployee_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvEmployee.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        /// <summary>
        /// Row Data Bound event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployee_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    DropDownList managerDropdownList = e.Row.FindControl("ddlManager") as DropDownList;
                    managerDropdownList.DataSource = DataContext.Employees
                                                    .Where(p => p is IManager)
                                                    .ToList();
                    managerDropdownList.DataTextField = "Name";
                    managerDropdownList.DataValueField = "EmployeeId";
                    managerDropdownList.DataBind();
                    managerDropdownList.Items.Insert(0, new ListItem("--Select--", ""));

                    IEmployee employee = e.Row.DataItem as Employee;
                    if (employee != null && employee.ReportingManager != null)
                    {
                        managerDropdownList.SelectedValue = Convert.ToString(employee.ReportingManager.EmployeeId);
                    }
                }
            }
        }

        /// <summary>
        /// Update event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployee_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow currentRow = gvEmployee.Rows[e.RowIndex];

            HiddenField employeeHidden = currentRow.FindControl("hidEmployeeId") as HiddenField;
            int employeeId = Convert.ToInt32(employeeHidden.Value);
            IEmployee employee = DataContext.Employees.FirstOrDefault(p => p.EmployeeId == employeeId);
            employee.Name = Convert.ToString(e.NewValues["Name"]);
            employee.Email = Convert.ToString(e.NewValues["Email"]);

            DropDownList managerDropdownList = currentRow.FindControl("ddlManager") as DropDownList;
            if (string.IsNullOrEmpty(managerDropdownList.SelectedValue))
            {
                employee.ReportingManager = null;
            }
            else
            {
                int selectedManagerId = Convert.ToInt32(managerDropdownList.SelectedValue);
                IEmployee manager = DataContext.Employees
                    .FirstOrDefault(p => p.EmployeeId == selectedManagerId);
                employee.ReportingManager = manager;
            }
            gvEmployee.EditIndex = -1;
            BindGrid();
        }

        /// <summary>
        /// Cancel Update operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployee_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvEmployee.EditIndex = -1;
            BindGrid();
        }

        /// <summary>
        /// Delete record event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployee_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int employeeId = Convert.ToInt32(e.Values["EmployeeId"]);
            IEmployee employee = DataContext.Employees.FirstOrDefault(p => p.EmployeeId == employeeId);
            DataContext.Employees.Remove(employee);
            BindGrid();
        }


    }
}