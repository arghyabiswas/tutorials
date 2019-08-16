using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADO.NETTutorial.DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectDataHandler PD = new ProjectDataHandler();

            
            Project project = new Project();
            project.Id = 2;
            project.Name = "Deepak Jena";
            project.Description = "Test Description";
            project.StartDate = DateTime.Now;
            project.EndDate = DateTime.Now.AddDays(10);
            project.IsActive = true;

            Console.WriteLine("....Please Choose one from the followings....");
            Console.WriteLine("");
            Console.WriteLine("1.Check Connection\n2.View All\n3.Load by Id\n4.Add/Edit\n5.Delete");
            Console.WriteLine("");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (i)
            {
                case 1:
                    bool isConnected = PD.IsConnected();
                    if (isConnected == true)
                    {
                        Console.WriteLine("DataBase has been Connected Successfully");
                        Console.ReadKey();
                    }
                    break;

                case 2:
                    Console.WriteLine(PD.LoadAllProjects());
                    Console.ReadKey();
                    break;

                case 3:
                    Project data = new Project();
                    data = PD.LoadProjectById(project.Id);
                    Console.WriteLine(data.Id);
                    Console.WriteLine(data.Name);
                    Console.WriteLine(data.Description);
                    Console.WriteLine(data.StartDate);
                    Console.WriteLine(data.EndDate);
                    Console.WriteLine(data.IsActive);
                    Console.ReadKey();
                    break;

                case 4:
                    PD.AddEditProject(project);
                    Console.ReadKey();
                    break;

                case 5:
                    PD.Delete(project.Id);
                    Console.ReadKey();
                    break;

            }


            
        }
    }
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
            dbConnectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
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

                foreach (DataRow DR in dtProjects.Rows)
                {
                    Console.WriteLine(DR["ID"]);
                    Console.WriteLine(DR["Name"]);
                    Console.WriteLine(DR["Description"]);
                    Console.WriteLine(DR["StartDate"]);
                    Console.WriteLine(DR["EndDate"]);
                    Console.WriteLine(DR["IsActIve"]);
                    Console.WriteLine();
                }

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

        public void AddEditProject(Project project)
        {
            
            using (SqlConnection oCnn = new SqlConnection())
            {
                oCnn.ConnectionString = dbConnectionString;
                try
                {
                    oCnn.Open();

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

                        Console.WriteLine("ID is " + id);

                        if (project.Id == 0)
                        {
                            Console.WriteLine("New Row Added");
                        }
                        else
                        {
                            Console.WriteLine("One Row edited");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            
        }

        public void Delete(int Id)
        {
            
            using (SqlConnection oCnn = new SqlConnection())
            {
                oCnn.ConnectionString = dbConnectionString;
                try
                {
                    oCnn.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = oCnn;

                        command.CommandText = "DeleteProject";
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("Id", SqlDbType.Int);
                        command.Parameters["Id"].Value = Id;


                        command.ExecuteNonQuery();
                        Console.WriteLine("Id Deleted Successfully");

                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public Project LoadProjectById(int id)
        {
            Project project = null;

            connection.Open();

            using (SqlCommand oCmd = new SqlCommand())
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

                    if (reader.NextResult())
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


    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }


        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }

    }

}
