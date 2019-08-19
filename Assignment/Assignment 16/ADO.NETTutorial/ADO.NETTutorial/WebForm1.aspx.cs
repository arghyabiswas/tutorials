using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO.NETTutorial
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Create a connection object  
            string ConnectionString = ConfigurationManager.ConnectionStrings["TutorialConnection"].ConnectionString;

            SqlConnection conn = new SqlConnection(ConnectionString);

            // open the connection  
            conn.Open();

            // Create a data adapter object  
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Projects", conn);

            // Create a command builder object  
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            // Create a data Set object  
            DataSet ds = new DataSet("ProjectSet");
            adapter.Fill(ds, "Projects");

            // Create a data table object and add a new row  
            DataTable dtProject = ds.Tables["Projects"];

            //dtProject.PrimaryKey = new DataColumn[1] { dtProject.Columns["Id"] };
            if (dtProject.Rows.Count > 0)
            {
                // Update
                DataRow row = dtProject.Rows[2];
                row.SetModified();
                row["Name"] = "ASP.NET";
                row["StartDate"] = DateTime.Now;
                row["EndDate"] = DateTime.Now.AddDays(4);
            }

            // Insert
            DataRow row2 = dtProject.NewRow();
            row2["Name"] = "ADO.NET" + DateTime.Now.ToString();
            row2["StartDate"] = DateTime.Now;
            row2["EndDate"] = DateTime.Now.AddDays(10);
            dtProject.Rows.Add(row2);

            //// Delete
            dtProject.Rows[1].Delete();

            //// update data adapter  
            adapter.Update(ds, "Projects");

            GridView1.DataSource = dtProject;
            GridView1.DataBind();
           

            /*
            using (SqlConnection oCnn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand oCmd = new SqlCommand("SELECT COUNT(*) FROM Projects;SELECT * FROM Projects", oCnn))
                {
                    oCnn.Open();

                    using (SqlDataReader oRdr = oCmd.ExecuteReader())
                    {
                        while (oRdr.Read())
                        {
                            Response.Write(oRdr[0] + "<br />");
                        }

                        if (oRdr.NextResult())
                        {
                            while (oRdr.Read())
                            {
                                Response.Write(oRdr["Name"] + "<br />");
                            }
                        }
                    }
                }
                
            }*/
        }
    }
}