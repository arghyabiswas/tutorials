using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TutorialDay19.DAL
{
    class InsertRecord
    {
        public static bool Insert(Project project)
        {

            SqlConnection sqlConnection = null;
            try
            {
                int status = project.IsActive ? 1 : 0;
                sqlConnection = NewConnection.SQLConnection();
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = $"insert into Projects(Name,Description,StartDate,EndDate,IsActive) values ('{project.Name}','{project.Description}','{project.StartDate}','{project.EndDate}','{status}')";

                sqlCommand.CommandType = CommandType.Text;

                sqlCommand.Connection = sqlConnection;

                sqlDataAdapter.InsertCommand = sqlCommand;

                sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();

            }

            return true;
        }

    }
}
