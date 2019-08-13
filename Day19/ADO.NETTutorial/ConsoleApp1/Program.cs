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
            Console.WriteLine(isValid);
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


        public void AddUpdateProject(Project project)
        {
            SqlConnection oCnn = new SqlConnection();

            oCnn.ConnectionString = databaseConnectionString;
            oCnn.Open();


            SqlCommand command = new SqlCommand();
            command.Connection = oCnn;

            command.CommandText = "AddUpdateProject";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("Id", SqlDbType.Int);
            command.Parameters["Id"].Value = project.Id;

            command.Parameters.Add("Name", SqlDbType.VarChar,255);
            command.Parameters["Name"].Value = project.Name;

            command.Parameters.Add("Descrption", SqlDbType.NVarChar,1023);
            command.Parameters["Descrption"].Value = project.Description;

            command.Parameters.Add("StartDate", SqlDbType.DateTime);
            command.Parameters["StartDate"].Value = project.SartDate;

            command.Parameters.Add("EndDate", SqlDbType.DateTime);
            command.Parameters["EndDate"].Value = project.EndDate;

            command.Parameters.Add("IsActive", SqlDbType.Bit);
            command.Parameters["IsActive"].Value = project.IsActive;


            //command.ExecuteReader
            //command.ExecuteScalar
            command.ExecuteNonQuery();
            oCnn.Close();

            /*
             * 
             @Id int = null,	        @Name VARCHAR(255),	        @Descrption NVARCHAR(1023),	        @StartDate DATETIME, 	        @EndDate DATETIME,	        @IsActive BIT
            */
        }
    }

    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime SartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }
    }
}
