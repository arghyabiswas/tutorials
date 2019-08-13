using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace TutorialDay19
{
    class DisplayTable
    {
        DataTable tbl = new DataTable();
        DataDisplay dd = new DataDisplay();
        public void Display()
        {
            tbl = dd.LoadAllRecord();
            
            foreach (DataRow dr in tbl.Rows)
            {
                Console.WriteLine();
                string id = dr["id"].ToString();
                Console.WriteLine(id + "\t");
                string nm = dr["name"].ToString();
                Console.WriteLine(nm + "\t");
                string descr = dr["description"].ToString();
                Console.WriteLine(descr + "\t");
                string sd = dr["startdate"].ToString();
                Console.WriteLine(sd + "\t");
                string ed = dr["enddate"].ToString();
                Console.WriteLine(ed + "\t");
                string st = dr["isactive"].ToString();
                Console.WriteLine(st + "\t");
            }
            Console.ReadKey();
        }
        
    }
}
