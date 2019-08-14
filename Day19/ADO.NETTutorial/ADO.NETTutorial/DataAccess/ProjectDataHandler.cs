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
        /*
        TestConnection()
        LoadAll()
        LoadById(int id)
        AddEdit
        Delete
        */


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
        public bool AddEditProject(Project project)
        {
            bool isValid = false;


            using (SqlConnection oCnn = new SqlConnection())
            {
                oCnn.ConnectionString = dbConnectionString;
                try
                {
                    oCnn.Open();

                    /*
                    @Id int = null output,
                    @Name VARCHAR(255),
                    @Description NVARCHAR(1023),
                    @StartDate DATETIME, 
                    @EndDate DATETIME,
                    @IsActive BIT
                    */

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = oCnn;

                        command.CommandText = "AddUpdateProject";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("Id", SqlDbType.Int);
                        command.Parameters["Id"].Value = project.Id;
                        command.Parameters["Id"].Direction = ParameterDirection.InputOutput;

                        command.Parameters.Add("Name", SqlDbType.VarChar, 255);
                        command.Parameters["Name"].Value = project.Name;

                        command.Parameters.Add("Description", SqlDbType.NVarChar, 1023);
                        command.Parameters["Description"].Value = project.Description;

                        command.Parameters.Add("StartDate", SqlDbType.DateTime);
                        command.Parameters["StartDate"].Value = project.StartDate;

                        command.Parameters.Add("EndDate", SqlDbType.DateTime);
                        command.Parameters["EndDate"].Value = project.EndDate;

                        command.Parameters.Add("IsActive", SqlDbType.Bit);
                        command.Parameters["IsActive"].Value = project.IsActive;

                        command.ExecuteNonQuery();

                        int id = Convert.ToInt32(command.Parameters["Id"].Value);

                        isValid = true;
                    }
                }
                catch (Exception e)
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        public bool Delete(int Id)
        {
            // TODO
            return false;
        }



    }

}
