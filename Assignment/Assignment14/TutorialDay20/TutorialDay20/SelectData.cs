using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TutorialDay20
{
    class SelectData
    {
        public static string databaseConnectionString = ConfigurationManager.ConnectionStrings["dataBaseConnection"].ConnectionString;

        public static DataTable LoadAllProject(int data)
        {
            SqlConnection con = new SqlConnection(databaseConnectionString);
            DataTable dataTable = new DataTable();

            try
            {

                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand();
                if (data == 0)
                {
                    cmd.CommandText = "select * from Project";
                }
                else
                {
                    cmd.CommandText = $"select * from Project where id='{data}'";
                }

                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                adp.SelectCommand = cmd;
                adp.Fill(dataTable);

                foreach (DataRow dr in dataTable.Rows)
                {
                    Console.WriteLine(dr["id"]);
                    Console.WriteLine(dr["name"]);
                    Console.WriteLine(dr["IsActive"]);
                    Console.WriteLine(dr["StartDate"]);
                    Console.WriteLine(dr["EndDate"]);
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }
    }
}
