using ADO.NETTutorial.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string databaseConnectionString = ConfigurationManager.ConnectionStrings["SampleConnectionString"].ConnectionString;

        static void Main(string[] args)
        {

            bool isValid = TestConnection();
            Console.WriteLine("Is it Connected"+isValid);

            Project project = new Project();
            // project.Id = 4;
            project.Name = "Demo Proj";
            project.Description = "Bombay to Goa";
            project.StartDate = DateTime.Now;
            project.EndDate = DateTime.Now.AddDays(10);
            project.IsActive = true;

            isValid = AddUpdateProject(project);

            Console.WriteLine("\nIs AddUpdateProject Working "+isValid);

            //List<Project> projects = new List<Project>();
            //projects.Where(a => a.IsActive == true).ToList();

            Program p1 = new Program();

            ProjectDataHandler handler = new ProjectDataHandler();

            Console.WriteLine("\nLoading all the data");
            var data1 = handler.LoadAllProjects();
            foreach (DataRow dataRow in data1.Rows)
            {
                Console.WriteLine($"{dataRow["ID"]} {dataRow["Name"]} {dataRow["Descriptions"]} {dataRow["StartDate"]} {dataRow["EndDate"]} {dataRow["isActive"]}");
            }

            Console.WriteLine();
            Console.WriteLine("Enter row number to be deleted");
            int row_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            var deleteOutcome = handler.Delete(row_id);
            if (deleteOutcome)
                Console.WriteLine("Row delete was succesfull.");
            else
                Console.WriteLine("Row delete was unsuccesfull.");

            Console.WriteLine("");
            var count = handler.CountTotal();
            Console.WriteLine("Total Count is "+count);

            Console.WriteLine("Enter the ID number to be load the data");
            int loadid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            var pj = p1.loadProjectById(loadid);
            foreach (DataRow dataRow in pj.Rows)
            {
                Console.WriteLine($"{dataRow["ID"]} {dataRow["Name"]} {dataRow["Descriptions"]} {dataRow["StartDate"]} {dataRow["EndDate"]} {dataRow["isActive"]}");
            }

            Console.WriteLine("\nLoading all the data again");
            ProjectDataHandler handler1 = new ProjectDataHandler();
            var data2 = handler1.LoadAllProjects();
            foreach (DataRow dataRow in data2.Rows)
            {
                Console.WriteLine($"{dataRow["ID"]} {dataRow["Name"]} {dataRow["Descriptions"]} {dataRow["StartDate"]} {dataRow["EndDate"]} {dataRow["isActive"]}");
            }

            Console.ReadKey();

        }

        public static bool TestConnection()
        {
            bool isValid = false;
            SqlConnection oCnn = new SqlConnection();
            try
            {

                oCnn.ConnectionString = databaseConnectionString;
                oCnn.Open();
                isValid = true;
            }
            catch
            {
                isValid = false;
            }
            finally
            {
                oCnn.Close();
            }

            return isValid;
        }

        public static bool AddUpdateProject(Project project)
        {
            bool isValid = false;


            using(SqlConnection oCnn = new SqlConnection())
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

                    using(SqlCommand command = new SqlCommand())
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

        public DataTable loadProjectById(int id)
        {
            DataTable data = new DataTable();
            SqlConnection conn = new SqlConnection();
            try
            {
                conn = new SqlConnection(databaseConnectionString);
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = $"select * from projects where id ={id};";
                command.CommandType = CommandType.Text;
                
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);
            }
            catch (Exception e)
            {
                data = null;
            }
            finally
            {
                conn.Close();
            }
            return data;
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
