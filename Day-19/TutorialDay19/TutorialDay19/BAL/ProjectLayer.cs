using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialDay19.BAL
{
    class ProjectLayer
    {
        public static Project SetProject()
        {
            Project project = new Project();
            Console.WriteLine("Enter Name,Description,Project is Active or NOT.");

            Console.WriteLine("Project Name:");
            project.Name = Console.ReadLine();
            Console.WriteLine("Project Description");
            project.Description = Console.ReadLine();

            project.EndDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            project.StartDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\n\n1.Proect IsActive\n2.Project is Not Active");
                int input = 4;
                bool result = false;
                while (!result)
                {
                    result = int.TryParse(Console.ReadLine(), out input);
                }

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
    }
}
