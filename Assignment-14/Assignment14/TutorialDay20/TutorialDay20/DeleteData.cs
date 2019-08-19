using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialDay20
{
    class DeleteData
    {
        public static string databaseConnectionString = ConfigurationManager.ConnectionStrings["dataBaseConnection"].ConnectionString;

        public static bool deleteProject(int Id)
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
    }
}
