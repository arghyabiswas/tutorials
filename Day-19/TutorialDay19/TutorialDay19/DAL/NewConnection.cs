using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace TutorialDay19.DAL
{
    class NewConnection
    {
        private static string connectionString = @"Data Source=NIKOLASHLTOP\SQL2014;Initial Catalog = TutorialDay19; Integrated Security = True; Connect Timeout = 15; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static SqlConnection SQLConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;
        }

    }
}
