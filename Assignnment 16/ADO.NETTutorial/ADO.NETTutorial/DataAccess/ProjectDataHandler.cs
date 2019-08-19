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
        string databaseConnectionString;
        public ProjectDataHandler()
        {
            databaseConnectionString = @"Data Source=ASHUTOSHDLTOP\SQL2014;Initial Catalog=TutorialDay19;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection = new SqlConnection(databaseConnectionString);
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

        public bool AddProject(Project project)
        {
            bool isValid = false;


            using (SqlConnection oCnn = new SqlConnection())
            {
                oCnn.ConnectionString = databaseConnectionString;
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
            bool isSuccess = false;
            DataTable dataTable = new DataTable();
            SqlConnection con = new SqlConnection(databaseConnectionString);
            try
            {

                con.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = con;
                sqlCommand.CommandText = "DeleteProject";
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("Id", SqlDbType.Int);
                sqlCommand.Parameters["Id"].Value = Id;

                sqlCommand.ExecuteNonQuery();
                isSuccess = true;


            }
            catch (Exception e)
            {
                isSuccess = false;
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (con.State != ConnectionState.Closed)
                    con.Close();

            }
            return isSuccess;
        }

        public Project LoadProjectById(int id)
        {
            Project project = null;

            connection.Open();

            using(SqlCommand oCmd = new SqlCommand())
            {

                


                oCmd.Connection = connection;

                oCmd.CommandText = "SELECT COUNT(*) AS TOTAL  FROM Projects;SELECT * FROM Projects WHERE Id = @Id";
                oCmd.CommandType = CommandType.Text;


                oCmd.Parameters.Add("Id",SqlDbType.Int);
                oCmd.Parameters["Id"].Value = id;

                using (SqlDataReader reader = oCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int total = Convert.ToInt32(reader[0]);
                    }

                   if(reader.NextResult())
                    {
                        while (reader.Read())
                        {
                            project = new Project();
                            project.Id = Convert.ToInt32(reader["Id"]);
                            project.Name = Convert.ToString(reader["Name"]);

                            if (reader["Description"] != DBNull.Value)
                            {
                                project.Description = Convert.ToString(reader["Description"]);
                            }


                            project.StartDate = Convert.ToDateTime(reader["StartDate"]);
                            project.EndDate = Convert.ToDateTime(reader["EndDate"]);
                            project.IsActive = Convert.ToBoolean(reader["IsActive"]);
                        }
                    }

                   
                }
            }


            return project;
        }

        public int CountTotal()
        {
            connection.Open();

            using (SqlCommand oCmd = new SqlCommand())
            {
                oCmd.Connection = connection;

                oCmd.CommandText = "SELECT COUNT(*) AS TOTAL  FROM Projects";
                oCmd.CommandType = CommandType.Text;

                int total = Convert.ToInt32(oCmd.ExecuteScalar());

                return total;
            }
        }

        
    }

}
