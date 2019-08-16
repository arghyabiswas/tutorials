using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment_14
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectDataHandler PD = new ProjectDataHandler();
            bool isConnected = PD.IsConnected();
            if (isConnected == true)
            {
                Console.WriteLine("DataBase is Connected Successfully");
            }

            Project project = new Project();
            //project.Id = 9;
            project.Name = "Deepak Jena";
            project.Description = "Test Description";
            project.StartDate = DateTime.Now;
            project.EndDate = DateTime.Now.AddDays(10);
            project.IsActive = true;

            Console.WriteLine("....Please Choose one from the followings....");
            Console.WriteLine("");
            Console.WriteLine("1.Add/Edit\n2.Delete");
            Console.WriteLine("");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            switch (i)
            {
                case 1: PD.AddEditProject(project);
                    break;

                case 2: PD.DeleteProject(project);
                    break;

            }
         

            Console.WriteLine(PD.LoadAllProjects());

            Console.ReadKey();
        }
    }

    public class ProjectDataHandler
    {
       
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

        public void DeleteProject(Project project)
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
                        command.Parameters["Id"].Value = project.Id;


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

    }
}
