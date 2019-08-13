using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace TutorialDay20
{
    class Program
    {
        string databaseConnectionString = @"Data Source=ASHIRWADLTOP;Initial Catalog=TutorialDay19;Integrated Security=True";
        SqlConnection conn;
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            Project project = new Project();
            project.Name = "testing 2";
            project.Description = "testing 2";
            project.SartDate = DateTime.Now;
            project.EndDate = DateTime.Now.AddDays(10);
            project.IsActive = true;

                   
            bool isConnected = obj1.isConnected();
            if (isConnected)
                Console.WriteLine("Connected to the database");
            else
                Console.WriteLine("Could not connect to the database");
            Console.ReadLine();
            var data = obj1.loadAllData();
            foreach (DataRow dataRow in data.Rows)
            {
                Console.WriteLine($"{dataRow["ID"]} {dataRow["Name"]} {dataRow["Descriptions"]} {dataRow["StartDate"]} {dataRow["EndDate"]} {dataRow["isActive"]}");
            }
            Console.ReadLine();


            bool isValid = obj1.addEditProject(project);
            Console.WriteLine();
            if (isValid)
                Console.WriteLine("Insert query Executed Successfully");
            else
                Console.WriteLine("Query Execution Failed");
            Console.WriteLine();
            Console.WriteLine("Enter row number to be deleted");
            int row_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            var deleteOutcome = obj1.deleteRecord(row_id);
            if(deleteOutcome)
                Console.WriteLine("Row delete was succesfull.");
            else
                Console.WriteLine("Row delete was unsuccesfull.");
            Console.ReadLine();

            var data1 = obj1.loadAllData();
            foreach (DataRow dataRow in data1.Rows)
            {
                Console.WriteLine($"{dataRow["ID"]} {dataRow["Name"]} {dataRow["Descriptions"]} {dataRow["StartDate"]} {dataRow["EndDate"]} {dataRow["isActive"]}");
            }
            Console.ReadLine();


        }

        public Boolean isConnected()
        {
            bool isConnect = false;
            Program p1 = new Program();
            try
            {
                p1.conn = new SqlConnection(p1.databaseConnectionString);
                p1.conn.Open();
                isConnect = true;
            }
            catch (Exception e)
            {
                isConnect = false;
            }
            finally
            {
                p1.conn.Close();
            }
            return isConnect;
        }

        /// <summary>
        /// Function to display all the rows of the table projects present in the database tutorialDay19
        /// </summary>
        /// <returns></returns>
        public DataTable loadAllData()
        {
            DataTable data = new DataTable();
            Program p1 = new Program();
            try
            {
                p1.conn = new SqlConnection(p1.databaseConnectionString);
                p1.conn.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = p1.conn;
                command.CommandText = "execute loadAllData;";
                command.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(data);

            }
            catch (Exception e)
            {
                data = null;
            }
            finally
            {
                p1.conn.Close();
            }
            return data;

        }

        /// <summary>
        /// Function to delete a record on the basis of the id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool deleteRecord( int id )
        {
            bool isDeleted = false;
            Program p1 = new Program();
            p1.conn = new SqlConnection(p1.databaseConnectionString);
            try
            {
                p1.conn.Open();
                SqlCommand command = new SqlCommand($"execute deleteRecord {id}", p1.conn);
                command.ExecuteNonQuery();
                isDeleted = true;
            }
            catch (Exception e)
            {
                isDeleted = false;
            }
            finally {
                p1.conn.Close();
            }
            return isDeleted;
        }

        public bool addEditProject(Project project) {

            bool isValid = false;
            SqlConnection Conn = new SqlConnection();

            Conn.ConnectionString = databaseConnectionString;
            try
            {
                Conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = Conn;

                command.CommandText = "AddUpdateProject";
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("Id", SqlDbType.Int);
                command.Parameters["Id"].Value = project.Id;
                command.Parameters["Id"].Direction = ParameterDirection.InputOutput;

                command.Parameters.Add("Name", SqlDbType.VarChar, 255);
                command.Parameters["Name"].Value = project.Name;

                command.Parameters.Add("Description", SqlDbType.NVarChar, 1023);
                command.Parameters["Description"].Value = project.Description;

                command.Parameters.Add("StartDate", SqlDbType.DateTime);
                command.Parameters["StartDate"].Value = project.SartDate;

                command.Parameters.Add("EndDate", SqlDbType.DateTime);
                command.Parameters["EndDate"].Value = project.EndDate;

                command.Parameters.Add("IsActive", SqlDbType.Bit);
                command.Parameters["IsActive"].Value = project.IsActive;
                
                command.ExecuteNonQuery();

                int id = Convert.ToInt32(command.Parameters["id"].Value);

                isValid = true;


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                isValid = false;
            }
            finally
            {
                if (Conn.State != ConnectionState.Closed)
                {
                    Conn.Close();
                }
            }

            return isValid;
        }
    }
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime SartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool IsActive { get; set; }
    }

}    



