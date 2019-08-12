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
        SqlConnection conn = new SqlConnection(@"Data Source=MONALISALTOP\SQL2014;DataBase=TutorialDay19;Integrated Security = true");


        static void Main(string[] args)
        {
            Program pr = new Program();

            bool success = pr.Insert();
            if (success)
            {
                Console.WriteLine("Insertion Success..");
                pr.LoadAllRecords();

            }
            else
            {
                Console.WriteLine("Insertion Failed..");
                pr.LoadAllRecords();
            }
            Console.ReadKey();
        }
        public DataTable LoadAllRecords()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlDataAdapter sqa = new SqlDataAdapter("select * from Projects", conn);
                sqa.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Console.WriteLine(dr["ID"]);
                    Console.WriteLine(dr["Name"]);
                    Console.WriteLine(dr["Description"]);
                    Console.WriteLine(dr["StartDate"]);
                    Console.WriteLine(dr["EndDate"]);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return dt;
        }
        public bool Insert()
        {
            try
            {
                conn.Open();
                string s = @"insert into Projects(Name,Description,StartDate,EndDate) values('Subu','student','10-12-2002','08-12-2003')";
                SqlCommand cmd = new SqlCommand(s, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }


}

