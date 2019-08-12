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
        static string databaseConnection = @"Data Source=ASHIRWADLTOP;Initial Catalog=TutorialDay19;Integrated Security=True";
        static SqlConnection conn;
        static void Main(string[] args)
        {
            conn = new SqlConnection(databaseConnection);

            //string queryString = "select * from projects;";
            //conn.Open();
            //SqlCommand cmd = new SqlCommand(queryString, conn);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString()+" "+reader[3].ToString()+" "+reader[4].ToString()+" "+reader[5].ToString());
            //}
            //Console.ReadLine();
            bool queryAgain = true;
            while (queryAgain)
            {
                Console.WriteLine("Choose your option \n enter 0 for displaying all the records \n enter 1 for inserting a record");
                try
                {
                    int option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (option == 0)
                    {
                        var data = result();
                        foreach (DataRow dataRow in data.Rows)
                        {
                            Console.WriteLine($"{dataRow["ID"]} {dataRow["Name"]} {dataRow["Descriptions"]} {dataRow["StartDate"]} {dataRow["EndDate"]} {dataRow["isActive"]}");
                        }
                    }
                    else if (option == 1)
                    {
                        Console.WriteLine("Enter the name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the Descriptions:");
                        string descriptions = Console.ReadLine();
                        Console.WriteLine("Enter if its is Active(true/false):");
                        bool isActive = Convert.ToBoolean(Console.ReadLine());
                        //var isInsert = insertData("Bishal", "tada da da", DateTime.Now, DateTime.Now.AddDays(1), true);
                        var isInsert = insertData(name, descriptions, DateTime.Now, DateTime.Now.AddDays(1), isActive);
                        if (isInsert)
                        {
                            Console.WriteLine("inserted succesfully");
                        }
                        else {
                            Console.WriteLine("Not inserted");
                        }
                    }
                    else
                        Console.WriteLine("Please enter a valid option");
                }
                catch
                {
                    Console.WriteLine("Please enter a valid option");
                }
                Console.WriteLine();
                Console.Write("Do you want to query again(true/false)");
                queryAgain = Convert.ToBoolean(Console.ReadLine());
            }
            Console.ReadLine();
        }
        /// <summary>
        /// Function to display all the rows of the table projects present in the database tutorialDay19
        /// </summary>
        /// <returns></returns>
        public static DataTable result() {
            DataTable data = new DataTable();

            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "select * from projects;";
                command.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);

            }
            catch (Exception e)
            {
                data = null;
            }
            finally {
                conn.Close();
            }
            return data;

        }

        /// <summary>
        /// Function  to insert a row inside the table projects present in the database tutorialDay19
        /// </summary>
        /// <param name="name"></param>
        /// <param name="descriptions"></param>
        /// <param name="StartDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public static bool insertData(string name, string descriptions, DateTime StartDate, DateTime EndDate, bool isActive) {
            bool isExecuted = true;
            int active;
            if (isActive)
                active = 1;
            else
                active = 0;
            try {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = $"insert into projects(name,descriptions,StartDate,EndDate,isACtive) values('{name}','{descriptions}','{StartDate}','{EndDate}',{active})";
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                isExecuted = true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                isExecuted = false;
            }
            finally
            {
                conn.Close();
            }

            return isExecuted;
        }
    }
}
