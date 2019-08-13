using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace TutorialDay19.DAL
{
    class LoadRecord
    {
        /// <summary>
        /// Select Records from the Database
        /// </summary>
        /// <param name="myQuery"></param>
        /// <returns></returns>
        public static DataTable LoadAllRecord(string myQuery)
        {
            SqlConnection sqlConnection = null;
            DataTable dataTable = new DataTable();
            try
            {
                sqlConnection = NewConnection.SQLConnection();
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                SqlCommand sqlCommand = new SqlCommand();

                sqlCommand.CommandText = myQuery;

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;

                sqlDataAdapter.SelectCommand = sqlCommand;

                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();
            }

            return dataTable;
        }

    }
}
