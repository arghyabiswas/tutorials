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
        /// <summary>
        /// Insert and Update Records in the Database
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Bool</returns>
        public static bool Insert(Project project)
        {

            SqlConnection sqlConnection = null;
            try
            {
                int status = project.IsActive ? 1 : 0;
                sqlConnection = NewConnection.SQLConnection();
                sqlConnection.Open();

 


                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = "AddUpdateProject";

                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("Id", SqlDbType.Int);
                sqlCommand.Parameters["Id"].Value = project.Id;
                sqlCommand.Parameters["Id"].Direction = ParameterDirection.InputOutput;

                sqlCommand.Parameters.Add("Name", SqlDbType.VarChar);
                sqlCommand.Parameters["Name"].Value = project.Name;

                sqlCommand.Parameters.Add("Description", SqlDbType.NVarChar);
                sqlCommand.Parameters["Description"].Value = project.Description;


                sqlCommand.Parameters.Add("EndDate", SqlDbType.DateTime);
                sqlCommand.Parameters["EndDate"].Value = project.EndDate;

                sqlCommand.Parameters.Add("StartDate", SqlDbType.DateTime);
                sqlCommand.Parameters["StartDate"].Value = project.StartDate;


                sqlCommand.Parameters.Add("IsActive", SqlDbType.Bit);
                sqlCommand.Parameters["IsActive"].Value = status;

                sqlCommand.ExecuteNonQuery();

                Console.WriteLine($"Your Project Id id :{Convert.ToInt32(sqlCommand.Parameters["Id"].Value)}");


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
