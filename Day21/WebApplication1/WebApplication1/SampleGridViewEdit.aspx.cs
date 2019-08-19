using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<Student> students = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            populateStudents();
            if (!Page.IsPostBack)
            {
                GridView1.DataSource = students;// Collection
                GridView1.DataBind();
            }
        }

        void populateStudents()
        {
            students = new List<Student>();

            Student student1 = new Student();
            student1.Id = 1;
            student1.Name = "Bishal Dikhit_1";
            student1.Email = "bishal@esspl.com";

            students.Add(student1);

            Student student2 = new Student();
            student2.Id = 2;
            student2.Name = "Arghya";
            student2.Email = "bishal@esspl.com";

            students.Add(student2);

            Student student3 = new Student();
            student3.Id = 3;
            student3.Name = "Bishal Dikhit_3";
            student3.Email = "bishal@esspl.com";
            students.Add(student3);

            Student student4 = new Student();
            student4.Id = 4;
            student4.Name = "Bishal Dikhit_4";
            student4.Email = "bishal@esspl.com";
            students.Add(student4);

            Student student5 = new Student();
            student5.Id = 5;
            student5.Name = "Bishal Dikhit_5";
            student5.Email = "bishal@esspl.com";
            students.Add(student5);

            Student student6 = new Student();
            student6.Id = 6;
            student6.Name = "Bishal Dikhit_6";
            student6.Email = "bishal@esspl.com";
            students.Add(student6);

            Student student7 = new Student();
            student7.Id = 7;
            student7.Name = "Bishal Dikhit_7";
            student7.Email = "bishal@esspl.com";
            students.Add(student7);

            Student student8 = new Student();
            student8.Id = 8;
            student8.Name = "Bishal Dikhit_8";
            student8.Email = "bishal@esspl.com";
            students.Add(student8);

            Student student9 = new Student();
            student9.Id = 9;
            student9.Name = "Bishal Dikhit_9";
            student9.Email = "bishal@esspl.com";
            students.Add(student9);

            Student student10 = new Student();
            student10.Id = 10;
            student10.Name = "Bishal Dikhit_10";
            student10.Email = "bishal@esspl.com";

            students.Add(student10);

            Student student11 = new Student();
            student11.Id = 11;
            student11.Name = "Bishal Dikhit_11";
            student11.Email = "bishal@esspl.com";

            students.Add(student11);

            Student student12 = new Student();
            student12.Id = 12;
            student12.Name = "Bishal Dikhit_12";
            student12.Email = "bishal@esspl.com";

            students.Add(student12);
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;

            GridView1.DataSource = students;
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            var x = e.NewValues;
            int id = Convert.ToInt32(e.NewValues["Id"]);
            Student student = students.First(p => p.Id == id);


            student.Name = Convert.ToString(e.NewValues["Name"]);
            student.Email = Convert.ToString(e.NewValues["Email"]);

            GridView1.EditIndex = -1;
            GridView1.DataSource = students;
            GridView1.DataBind();

            
        }
    }

    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}