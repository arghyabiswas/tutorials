using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TutorialDay19
{

    class DataInsert
    {
        public void InserttoDB()
        {

            DatabaseInsert dbins = new DatabaseInsert();
            string name = "";
            string desc = "";
            String start = "";
            string end = "";
            bool isactive = true;
            bool insertornot = false;
            char ch='n';
            do
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter description: ");
                desc = Console.ReadLine();
                Console.WriteLine("Enter start date: ");
                start = Console.ReadLine();
                Console.WriteLine("Enter end date: ");
                end = Console.ReadLine();
                Console.WriteLine("Enter active status (true/false): ");
                isactive = Convert.ToBoolean(Console.ReadLine());
                insertornot = dbins.InsertIntoDb(name, desc, start, end, isactive);
                if (insertornot == true)
                    Console.WriteLine("Success !");
                else
                    Console.WriteLine("No rows inserted !");
                Console.WriteLine("Do you want to enter more ?(y/n): ");
                ch = char.Parse(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');
        }
    }
}
