﻿using System;
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

        public static string databaseConncectionString = @"Data Source=UTKALSLAPTOP\SQL2014;Initial Catalog=tutorialday19;Integrated Security=True;";

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
                cmd.CommandText = "select * from project ";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = newcom;

                dataAdapt.SelectCommand = cmd;
                dataAdapt.Fill(dataTable);

                foreach (DataRow dre in dataTable.Rows)
                {
                    Console.WriteLine(dre["Id"]);
                    Console.WriteLine(dre["Name"]);
                    Console.WriteLine(dre["Description"]);
                    Console.WriteLine(dre["Startdate"]);
                    Console.WriteLine(dre["Enddate"]);
                    Console.WriteLine(dre["isActive"]);

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
                cmd1.CommandText = "insert into Project(Name,Description,Startdate,Enddate,IsActive) values('ashutosh','active',8-8-2015,9-9-2019,1),('Bishal','active',7-9-2015,9-7-2019,1),('chiranjeev','active',10-8-2015,12-12-2019,1)";
                cmd1.CommandType = CommandType.Text;
                cmd1.Connection = newcom;

                dataAdapt1.SelectCommand = cmd1;
                dataAdapt1.Fill(dataTable);
                ab = true;

            }

            catch (Exception )
            {
                ab = false;

            }

            finally
            {
                if (newcom.State != System.Data.ConnectionState.Closed)
                {
                    newcom.Close();
                }


            }

            return ab;
        }

    }


}

