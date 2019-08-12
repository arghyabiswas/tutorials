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
        /// <summary>
        /// give the database server name and database name
        /// </summary>
        public static String dataBaseConnection = @"Data Source=DEEPAKJLTOP\SQL2014;Initial Catalog=TutorialDay19;Integrated Security=True";
        SqlConnection con = new SqlConnection(dataBaseConnection);

        static void Main(string[] args)
        {

            Program pr = new Program();
           
            bool success=pr.insertData();
            if(success==true)
            {
                Console.WriteLine("Data Inserted Successfully.....");
                pr.LoadAllRecord();
            }
            else
            {
                Console.WriteLine("Data is not Inserted.....");
                pr.LoadAllRecord();
            }

           
            Console.ReadLine();
        }

        /// <summary>
        /// for select statement
        /// </summary>
        /// <returns>It is of return type Data Table</returns>
        public DataTable LoadAllRecord()
        {

            DataTable dataTable = new DataTable();

            try
            {
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Projects";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                adp.SelectCommand = cmd;
                adp.Fill(dataTable);

                foreach (DataRow dr in dataTable.Rows)
                {
                    Console.WriteLine(dr["id"]);
                    Console.WriteLine(dr["name"]);
                    Console.WriteLine(dr["IsActive"]);
                    Console.WriteLine(dr["StartDate"]);
                    Console.WriteLine(dr["EndDate"]);
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }

        /// <summary>
        /// For Inserting Data into DataBase
        /// </summary>
        /// <returns>it is of boolean type</returns>
        public bool insertData()
        {
            DataTable dataTable = new DataTable();
            try
            {
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter();

                SqlCommand insertCommand = new SqlCommand();

                insertCommand.CommandText = "insert into Projects(name,Description,StartDate, EndDate,IsActive)values('Amlan','EDI', '06-11-2017', '02-12-2021',1),('abhiseksahoo','oh ye abhi','07-10-2008','01-12-2018',0)";
                insertCommand.Connection = con;
                adp.InsertCommand = insertCommand;
                adp.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception e)
            {
               
                return false;
            }
            finally
            {
                con.Close();
            }
            return true;
        }
    }
}
