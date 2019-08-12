using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TutorialDay19
{
    class Program
    {
        static SqlConnection connection;
        static string dataConnection = "DATA SOURCE=CHIRANJEEVPC; INITIAL CATALOG=TutorialDay19; INTEGRATED SECURITY=TRUE;";

        static void Main(string[] args)
        {
            bool isSuccess = AddProject();
            Console.WriteLine("The record has been inserted successfully?");
            Console.WriteLine(isSuccess);
            Console.WriteLine("");
            LoadAllRecord();
            Console.ReadKey();

        }

        public static void LoadAllRecord()
        {

            DataTable dataTable = new DataTable();

            connection = new SqlConnection(dataConnection);
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            command.CommandText = "select * from Projects";
            command.CommandType = CommandType.Text;


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = command;
            sqlDataAdapter.Fill(dataTable);

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Console.WriteLine(dataRow["Id"]);
                Console.WriteLine(dataRow["Name"]);
                Console.WriteLine(dataRow["Description"]);
                Console.WriteLine(dataRow["StartDate"]);
                Console.WriteLine(dataRow["EndDate"]);
                Console.WriteLine(dataRow["IsActive"]);
                Console.WriteLine("New Row");
                Console.WriteLine("");
            }

        }

        public static bool AddProject()
        {
            bool isSuccess = false;
            try
            {

                connection = new SqlConnection(dataConnection);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandText = "insert into Projects values ('Utkal','Null','08/12/2019','08/15/2019',0);";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                isSuccess = true;
            }
            catch (Exception e)
            {
                isSuccess = false;
            }
            finally
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return isSuccess;
        }
    }
}
