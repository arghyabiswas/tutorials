using ADO.NETTutorial.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.NETTutorial.DataAccess.Modules;

namespace ConsoleApp1
{
    class Program
    {
        static string databaseConnectionString = ConfigurationManager.ConnectionStrings["SampleConnectionString"].ConnectionString;

        static void Main(string[] args)
        {

            
            Project project = new Project();
            // project.Id = 4;
            project.Name = "Demo Proj";
            project.Description = "Bombay to Goa";
            project.StartDate = DateTime.Now;
            project.EndDate = DateTime.Now.AddDays(10);
            project.IsActive = true;
            

            //List<Project> projects = new List<Project>();
            //projects.Where(a => a.IsActive == true).ToList();

            Program p1 = new Program();

            ProjectDataHandler handler = new ProjectDataHandler();

            var isConnected = handler.IsConnected();
            Console.WriteLine("Connection Established: "+isConnected);

            var isValid = handler.AddEditProject(project);
            Console.WriteLine("\nIs AddUpdateProject Working " + isValid);

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
            Console.WriteLine("Total Count is " + count);



            Console.WriteLine("Enter the ID number to be load the data");
            int loadId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //var pj = handler.LoadProjectById(5);
            //Console.WriteLine($"{pj.Name} {pj.Description} {pj.StartDate} {pj.EndDate} {pj.IsActive}");

            var pj = p1.loadProjectById(loadId);
            foreach (DataRow dataRow in pj.Rows)
            {
                Console.WriteLine($"{dataRow["ID"]} {dataRow["Name"]} {dataRow["Descriptions"]} {dataRow["StartDate"]} {dataRow["EndDate"]} {dataRow["isActive"]}");
                Console.WriteLine();
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

}
