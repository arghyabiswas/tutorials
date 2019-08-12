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
        public static bool Insert()
        {

            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = NewConnection.SQLConnection();
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = "insert into Projects(Name,Description,StartDate,EndDate,IsActive) values ('Nikolash Beura','ADO DOT NET','2019-08-12 00:00:00','2019-08-12 00:00:00',0)";

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
