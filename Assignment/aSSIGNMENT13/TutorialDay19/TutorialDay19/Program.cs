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

      public static string databaseConncectionString = @"Data Source=SHREYAS-PC\SQL2014;Initial Catalog=TutorialDay19;Integrated Security=True;";

       static SqlConnection newcom = new SqlConnection(databaseConncectionString);

        public static void Main(string[] args)
        {
            Program pp = new Program();

            pp.LoadAllRecord();

            bool status = insertData();
            Console.WriteLine("The record has been inserted?");
            Console.WriteLine(status);
            Console.WriteLine("");
           
            Console.ReadKey();



        }

        public DataTable LoadAllRecord()
        {
            DataTable dataTable = new DataTable();
           
            try
            {
                newcom.Open();
                SqlDataAdapter dataAdapt = new SqlDataAdapter();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Project ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = newcom;

                dataAdapt.SelectCommand = cmd;
                dataAdapt.Fill(dataTable);

                foreach (DataRow dre in dataTable.Rows)
                {
                    Console.WriteLine(dre["id"]);
                    Console.WriteLine(dre["Name"]);
                    Console.WriteLine(dre["isActive"]);
                    Console.WriteLine(dre["StartDate"]);
                    Console.WriteLine(dre["EndDate"]);
                };
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            finally
            {
                newcom.Close();
            }
            return dataTable;

         

        }
     
        public static bool insertData()
        {
            bool ab = false; 
            try
            {
                newcom.Open();
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapt1 = new SqlDataAdapter();



                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandText = "insert into Project(Name,Description,StartDate,EndDate,IsActive) values('Aseem','active',8-8-2015,9-9-2019,1),('Bishal','active',7-9-2015,9-7-2019,1),('Utkal','active',10-8-2015,12-12-2019,1)";
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = newcom;

                dataAdapt1.SelectCommand = cmd1;
                dataAdapt1.Fill(dataTable);
                ab = true;
                
            }

            catch (Exception e)
            {
                ab = false;

            }

            finally
            { 
                if (newcom.State!=System.Data.ConnectionState.Closed)
                {
                    newcom.Close();
                }
                
                
            }

            return ab;   
        }

    }

        
}


