using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialDay19.DAL;

namespace TutorialDay19.BAL
{
    class ProjectLayer
    {
        /// <summary>
        /// Takes the Required inputs for the Database insertion
        /// </summary>
        /// <returns>Object of a Proect Type</returns>
        public static Project SetProject(int Id)
        {
            Project project = new Project();
            Console.WriteLine("Enter Name,Description,Project is Active or NOT.");

            Console.WriteLine("Project Name:");
            project.Name = Console.ReadLine();
            Console.WriteLine("Project Description");
            project.Description = Console.ReadLine();

            project.EndDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (Id == 0)
            {
                project.StartDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }


            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\n\n1.Proect IsActive\n2.Project is Not Active");
                int input = ProjectLayer.GetInteger();

                switch (input)
                {
                    case 1:
                        project.IsActive = true;
                        flag = false;
                        break;
                    case 2:
                        project.IsActive = false;
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Make a Correct Choice.");
                        break;
                }
            }

            return project;
        }


        /// <summary>
        /// Add a new Project to the Database, Takes the Required inputs for the Database insertion
        /// </summary>
        /// <returns>Object of a Project Type</returns>
        public static Project AddNewProject()
        {
            return SetProject(0);
        }

        public static Project EditProject(int Id)
        {
            return SetProject(Id);
        }

        /// <summary>
        /// Returns details of the Project by Taking the ID of the Project
        /// </summary>
        /// <param name="Id">Project-Id</param>
        /// <returns>Project details against the Id</returns>
        public static Project GetProjectDetails(int Id)
        {
            Project project = new Project();
            string queryString = $"select * from Projects where Id='{Id}'";
            DataTable dataTable = LoadRecord.LoadAllRecord(queryString);
            if (dataTable != null)
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    project.Id = Convert.ToInt32(dataRow["Id"]);
                    project.Name = Convert.ToString(dataRow["Name"]);
                    project.Description = Convert.ToString(dataRow["Description"]);
                    project.StartDate = Convert.ToString(dataRow["StartDate"]);
                    project.EndDate = Convert.ToString(dataRow["EndDate"]);
                    project.IsActive = Convert.ToBoolean(dataRow["IsActive"]);
                }
                return project;
            }
            else
            {
                Console.WriteLine("Invalid Project-Id");
                return null;
            }

        }


        /// <summary>
        /// Returns int type value from Console
        /// </summary>
        /// <returns>Int</returns>
        public static int GetInteger()
        {
            int inputFlag = 4;
            bool resultFlag = false;
            while (!resultFlag)
            {
                resultFlag = int.TryParse(Console.ReadLine(), out inputFlag);
            }
            return inputFlag;
        }
    }
}
