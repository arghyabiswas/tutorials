using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TutorialDay19
{
    class DatabaseInsert
    {
        String cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        SqlCommand cmd = new SqlCommand();
        
        public bool InsertIntoDb(string name, string desc, string start, string end, bool active)
        {
            SqlConnection con = new SqlConnection(cs);
            cmd.CommandText = "insert into projects (name, description, startdate, enddate, isactive) values (@nm,@desc,@start,@end,@active)";
            cmd.Parameters.AddWithValue("@nm", name);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);
            cmd.Parameters.AddWithValue("@active", active);
            cmd.Connection = con;
            con.Open();
            int rows = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            con.Close();
            if (rows > 0)
                return true;
            else
                return false;
        }
    }
}
