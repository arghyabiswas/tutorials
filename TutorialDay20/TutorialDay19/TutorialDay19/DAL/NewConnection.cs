using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TutorialDay19.DAL
{
    class NewConnection
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["globalConnectionString"].ConnectionString;
    
        /// <summary>
        /// Connection String To the Database
        /// </summary>
        /// <returns></returns>
        public static SqlConnection SQLConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }

    }
}
