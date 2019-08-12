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
                Console.Write(id + "\t");
                string nm = dr["name"].ToString();
                Console.Write(nm + "\t");
                string descr = dr["description"].ToString();
                Console.Write(descr + "\t");
                string sd = dr["startdate"].ToString();
                Console.Write(sd + "\t");
                string ed = dr["enddate"].ToString();
                Console.Write(ed + "\t");
                string st = dr["isactive"].ToString();
                Console.Write(st + "\t");
            }
            Console.ReadKey();
        }
        
    }
}
