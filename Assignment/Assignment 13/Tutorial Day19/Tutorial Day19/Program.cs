using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Tutorial_Day19
{
    class Program
    {
        static string databaseConnectionString = @"Data Source=BISHALLTOP\SQL2014;Initial Catalog=Tutorial Day19;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(databaseConnectionString);
        SqlDataAdapter dataAdapter = new SqlDataAdapter();

        static void Main(string[] args)
        {
            Program LoadTable = new Program();
            bool checkForInsert = LoadTable.insertFunction();
            if (checkForInsert == true)
            {
                LoadTable.LoadAllRecord();
            }

            else
            {
                LoadTable.LoadAllRecord();

            }

            Console.Read();


        }

        public DataTable LoadAllRecord()
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = "select * from Details_Employee";
                command.CommandType = CommandType.Text;
                command.Connection = connection;

                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                foreach (DataRow DR in dataTable.Rows)
                {
                    Console.WriteLine(DR["ID"]);
                    Console.WriteLine(DR["Name"]);
                    Console.WriteLine(DR["Description"]);
                    Console.WriteLine(DR["StartDate"]);
                    Console.WriteLine(DR["EndDate"]);
                    Console.WriteLine(DR["IsActIve"]);
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                connection.Close();
            }

            Console.ReadKey();
            return dataTable;

        }

        public bool insertFunction()
        {

            try
            {
                connection.Open();
                SqlCommand insertcommand = new SqlCommand();
                insertcommand.CommandText = "insert into [dbo].[Details_Employee](ID,Name,Description,StartDate,EndDate,IsActive) values(1,'Nikolash Beura', 'Trainee', '10-05-2011', '10-06-2020', 1), (2,'Bishal Dikhit','Trainee', '10-07-2012','10-08-2017',1), (3,'Utkal Sahoo','Trainee', '10-07-2013','10-08-2018',1), (4,'Amlan Mishra','Trainee', '10-07-2011','10-08-2021',0), (5,'Abhisek Sahoo','Trainee', '10-07-2012','10-08-2014',0) ";
                insertcommand.CommandType = CommandType.Text;
                insertcommand.Connection = connection;
                dataAdapter.InsertCommand = insertcommand;
                dataAdapter.InsertCommand.ExecuteNonQuery();

            }

            catch (Exception)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }

            return true;


        }

    }
}

