using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialDay20
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("\n1.Insert\n2.View\n3.Edit\n4.Delete\n5.Exit");
            Console.WriteLine("Enter Your Choice");
            int choice = 0;
            choice = Convert.ToInt16(Console.ReadLine());
            switch(choice)
            {
                case 1:

                    bool success = InsertUpdateData.AddEditProject(0);
                    if (success == true)
                    {
                        Console.WriteLine("Data Inserted Successfully.....");
                        
                    }
                    else
                    {
                        Console.WriteLine("Data is not Inserted.....");
                       
                    }

                    break;

                case 2:
                    SelectData.LoadAllProject(0);
                    break;

                case 3:
                    Console.WriteLine("Enter Id to Edit :");
                    int eId = Convert.ToInt16(Console.ReadLine());
                    SelectData.LoadAllProject(eId);
                    Console.WriteLine("Edit Informatation");
                    bool successFlag = InsertUpdateData.AddEditProject(eId);
                    if (successFlag == true)
                    {
                        Console.WriteLine("Data updated Successfully.....");

                    }
                    else
                    {
                        Console.WriteLine("Error in Data Updatation.....");

                    }
                    break;

                case 4:
                    Console.WriteLine("Enter Id to Delete :");
                    int dId = Convert.ToInt16(Console.ReadLine());
                    bool res = DeleteData.deleteProject(dId);
                    if (res)
                    {
                        Console.WriteLine("Deleted Successfully..");

                    }
                    else
                    {
                        Console.WriteLine("Not Deleted..");
                    }
                    break;

                case 5:
                    return;
                    

                 default:
                    Console.WriteLine("Make a Correct Choice.");
                    break;
            }
            Console.ReadLine();

        }
    }
}
