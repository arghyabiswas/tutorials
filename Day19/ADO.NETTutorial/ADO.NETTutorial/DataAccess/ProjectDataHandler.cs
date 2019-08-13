using ADO.NETTutorial.DataAccess.Modules;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADO.NETTutorial.DataAccess
{
    public class ProjectDataHandler
    {
        SqlConnection connection;
        string dbConnectionString;
        public ProjectDataHandler()
        {
            dbConnectionString = "Data Source=INSTANCE-1;Initial Catalog=Tutorial;user id=sa;password=Admin@123";
            connection = new SqlConnection(dbConnectionString);
        }

        /// <summary>
        /// Checking if the database can be connected. using the provided connection string 
        /// </summary>
        /// <returns></returns>
        public bool IsConnected()
        {
            bool isConnected = false;
            try
            {
                connection.Open();
                isConnected = true;
            }
            catch
            {
                isConnected = false;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return isConnected;
        }

        /// <summary>
        /// Loading all record of the project table
        /// </summary>
        /// <returns></returns>
        public DataTable LoadAllProjects()
        {
            DataTable dtProjects = new DataTable();

            try
            {
                connection.Open();

                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = connection;
                oCmd.CommandText = "SELECT * FROM Projects";
                oCmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = oCmd;
                da.Fill(dtProjects);

            }
            catch
            {
                dtProjects = null;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }


            return dtProjects;
        }

        /// <summary>
        /// Add a record to the project table
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        public bool AddProject(Project project)
        {
            bool isSuccess = false;
            try
            {
                connection.Open();

                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = connection;
                oCmd.CommandText = "INSERT INTO Projects (Name,StartDate,EndDate) values(@Name,@StartDate,@EndDate)";
                oCmd.CommandType = CommandType.Text;

                oCmd.Parameters.Add("Name", SqlDbType.VarChar, 255);
                oCmd.Parameters["Name"].Value = project.Name;

                oCmd.Parameters.Add("StartDate", SqlDbType.DateTime);
                oCmd.Parameters["StartDate"].Value = project.StartDate;

                oCmd.Parameters.Add("EndDate", SqlDbType.DateTime);
                oCmd.Parameters["EndDate"].Value = project.EndDate;

                oCmd.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception e)
            {
                isSuccess = false;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }

            return isSuccess;



        }

        public bool AddProject_Using_Adapter(Project project)
        {
            bool isSuccess = false;
            SqlDataAdapter adapter = new SqlDataAdapter();
            connection.Open();

            string sql = "INSERT INTO Projects (Name,StartDate,EndDate) values(@Name,@StartDate,@EndDate)";
            try
            {
                adapter.InsertCommand = new SqlCommand(sql, connection);

                adapter.InsertCommand.CommandType = CommandType.Text;

                adapter.InsertCommand.Parameters.Add("Name", SqlDbType.VarChar, 255);
                adapter.InsertCommand.Parameters["Name"].Value = project.Name;

                adapter.InsertCommand.Parameters.Add("StartDate", SqlDbType.DateTime);
                adapter.InsertCommand.Parameters["StartDate"].Value = project.StartDate;

                adapter.InsertCommand.Parameters.Add("EndDate", SqlDbType.DateTime);
                adapter.InsertCommand.Parameters["EndDate"].Value = project.EndDate;

                adapter.InsertCommand.ExecuteNonQuery();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
            }
            finally
            {
                adapter.Dispose();
                connection.Close();
            }

            return isSuccess;
        }

        /// <summary>
        /// Loading single record of the table project
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Project LoadProjectById(int id)
        {
            Project project;
            SqlDataReader reader = null;
            try
            {
                connection.Open();

                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = connection;
                oCmd.CommandText = "SELECT * FROM Projects WHERE Id = @Id";
                oCmd.CommandType = CommandType.Text;

                oCmd.Parameters.Add("Id", SqlDbType.Int);
                oCmd.Parameters["Id"].Value = id;

                reader = oCmd.ExecuteReader();
                project = new Project();
                while (reader.Read())
                {
                    project.Id = Convert.ToInt32(reader["Id"]);
                    project.Name = Convert.ToString(reader["Name"]);
                    project.Description = Convert.ToString(reader["Description"]);
                    project.StartDate = Convert.ToDateTime(reader["StartDate"]);
                    project.EndDate = Convert.ToDateTime(reader["EndDate"]);
                    project.IsActive = Convert.ToBoolean(reader["IsActive"]);

                    //reader.NextResult();
                }
                
            }
            catch (Exception e)
            {
                project = null;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }

                reader.Close();
            }

            return project;
        }
    }
}