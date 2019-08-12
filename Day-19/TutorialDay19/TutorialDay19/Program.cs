using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TutorialDay19.DAL;
using TutorialDay19.BAL;

namespace TutorialDay19
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n\n1.Insert Record\n2.View Records\n3.Exit");
                int input = 4;
                bool result = false;
                while (!result)
                {
                    result = int.TryParse(Console.ReadLine(), out input);
                }

                switch (input)
                {
                    case 1:
                        Project project = ProjectLayer.SetProject();
                        bool success= InsertRecord.Insert(project);
                        if (success)
                        {
                            Console.WriteLine("Result Inserted");
                        }
                        else
                        {
                            Console.WriteLine("Error in Inserting Data Try Again.");
                        }
                        
                        break;
                    case 2:

                        Console.WriteLine("Enter Your Database Query(Table Name is Projects.)");
                        string query = Console.ReadLine();
                        DataTable dataTable = LoadRecord.LoadAllRecord(query);
                        if(dataTable != null)
                        {
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                Console.WriteLine(dataRow["Id"] + " || " + dataRow["Name"] + " || " + dataRow["Description"] + " || " + dataRow["StartDate"] + " || " + dataRow["EndDate"] + " || " + dataRow["IsActive"]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Query");
                        }


                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Make a Correct Choice.");
                        break;
                }
            }
        }
    }
}
