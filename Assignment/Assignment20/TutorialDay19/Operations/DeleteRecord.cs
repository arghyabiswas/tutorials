using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialDay19.DAL
{
    class DeleteRecord
    {
        /// <summary>
        /// Delete Record from the database by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static bool Delete(int Id)
        {
            bool isSuccess = false;
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = NewConnection.SQLConnection();
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

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
                if (sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();

            }
            return isSuccess;

        }
    }
}