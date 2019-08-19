using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialDay20
{
    class InsertUpdateData
    {
        public static int id;
        public static string name;
        public static string desc;
        public static DateTime dtmstartDate;
        public static DateTime dtmendDate;
        public static bool isActive;
    
        public static string databaseConnectionString = ConfigurationManager.ConnectionStrings["dataBaseConnection"].ConnectionString;
        

        public static bool AddEditProject(int data)
        {
            if(data!=0)
            {
                id = data;
            }
            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();

            Console.WriteLine("Enter Description :");
            desc = Console.ReadLine();

            Console.WriteLine("Enter StartDate :(mm/dd/yyyy)");
            string date = Console.ReadLine();           
            DateTime dtmstartDate = DateTime.Parse(date);
           
            

            Console.WriteLine("Enter EndDate :(mm/dd/yyyy)");
            string date2 = Console.ReadLine();
            DateTime dtmendDate = DateTime.Parse(date2);

            Console.WriteLine("Enter Activity Status :");
            isActive = Convert.ToBoolean(Console.ReadLine());

            //DataTable dataTable = new DataTable();
            SqlConnection con = new SqlConnection(databaseConnectionString);
            try
            {
                con.Open();
                //SqlDataAdapter adp = new SqlDataAdapter();
                //int a = 0;
                // SqlCommand insertCommand = new SqlCommand($"insert into Projects(Name,Description,StartDate, EndDate,IsActive)values('{InsertUpdateData.name}', '{InsertUpdateData.desc}','{dtmstartDate}','{dtmendDate}','{InsertUpdateData.isActive}')",con);
                //insertCommand.ExecuteNonQuery();

                SqlCommand sqlcommand = new SqlCommand();
                sqlcommand.Connection = con;
                sqlcommand.CommandText = "AddUpdateProject";
                sqlcommand.CommandType = CommandType.StoredProcedure;

                sqlcommand.Parameters.Add("Id", SqlDbType.Int);
                sqlcommand.Parameters["Id"].Value = InsertUpdateData.id;
                sqlcommand.Parameters["Id"].Direction = ParameterDirection.InputOutput;

                sqlcommand.Parameters.Add("Name", SqlDbType.VarChar);
                sqlcommand.Parameters["Name"].Value = InsertUpdateData.name;

                sqlcommand.Parameters.Add("Description", SqlDbType.NVarChar);
                sqlcommand.Parameters["Description"].Value = InsertUpdateData.desc;


                sqlcommand.Parameters.Add("EndDate", SqlDbType.DateTime);
                sqlcommand.Parameters["EndDate"].Value = dtmstartDate;

                sqlcommand.Parameters.Add("StartDate", SqlDbType.DateTime);
                sqlcommand.Parameters["StartDate"].Value = dtmendDate;


                sqlcommand.Parameters.Add("IsActive", SqlDbType.Bit);
                sqlcommand.Parameters["IsActive"].Value = InsertUpdateData.isActive;

                
                
                sqlcommand.ExecuteNonQuery();
                

                Console.WriteLine($"Your Project Id id :{Convert.ToInt32(sqlcommand.Parameters["Id"].Value)}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                con.Close();
            }

            return true;
        }
    }
}
