using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TutorialDay19
{
    class DataDisplay
    {
        string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        public DataTable LoadAllRecord()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select * from projects";
            cmd.Connection = con;
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
