using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialDay19.BAL;

namespace TutorialDay19.DAL
{
    class SelectionOption
    {
        /// <summary>
        ///  Switch case for  = Operations  done By the Program on the Database.
        /// </summary>
        public static void DbOperation()
        {
            while (true)
            {
                Console.WriteLine("\n\n1.Insert Record	\n2.View Records	\n3.Edit(By Project-Id)	\n4.Delete(By Project-Id)	\n5.Exit");
                int input = ProjectLayer.GetInteger();

                switch (input)
                {
                    case 1:
                        Project project = ProjectLayer.AddNewProject();
                        bool success = InsertRecord.Insert(project);
                        if (success)
                        {
                            Console.WriteLine("  Inserted");
                        }
                        else
                        {
                            Console.WriteLine("Error in Inserting Data Try Again.");
                        }

                        break;
                    case 2:
                        DataTable dataTable = LoadRecord.LoadAllRecord("select * from Projects");
                        if (dataTable != null)
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
                        Console.WriteLine("\nEnter Your Project Id");
                        int inputFlag = ProjectLayer.GetInteger();
                        Project projectEdit = new Project();
                        projectEdit = ProjectLayer.GetProjectDetails(inputFlag);

                        if(projectEdit!=null)
                        {
                            Console.WriteLine($"Project-Id: {projectEdit.Id}");
                            Console.WriteLine($"Project-Name: {projectEdit.Name}");
                            Console.WriteLine($"Project-Description: {projectEdit.Description}");
                            Console.WriteLine($"Project-Start Date: {projectEdit.StartDate}");
                            Console.WriteLine($"Project-End Date: {projectEdit.EndDate}");
                            Console.WriteLine($"Project-Active: {projectEdit.IsActive}");
                        }

                        Console.WriteLine("Enter 1 to Update Project Details");
                        int editOption = ProjectLayer.GetInteger();
                        if(editOption==1)
                        {
                            Project projectEdited = ProjectLayer.AddNewProject();
                            projectEdited.Id = projectEdit.Id;
                            projectEdited.StartDate = projectEdit.StartDate;
                            bool isUpdated = InsertRecord.Insert(projectEdited);
                            if (isUpdated)
                            {
                                Console.WriteLine("Result Updated");
                            }
                            else
                            {
                                Console.WriteLine("Error in Updating Data Try Again.");
                            }
                        }

                        break;
                    case 4:
                        Console.WriteLine("\nEnter Your Project Id");
                        int inputDelete = ProjectLayer.GetInteger();
                        bool isDeleted = DeleteRecord.Delete(inputDelete);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Enter your Choice.");
                        break;
                }
            }
        }
    }
}
