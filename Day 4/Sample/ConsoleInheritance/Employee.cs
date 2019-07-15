using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    sealed class ParmanentEmployee : Employee
    {
        double YearlySalary;
        public ParmanentEmployee()
             : base("No First Name", "No Last Name")
        {

        }

        public ParmanentEmployee(string firstName, string lastName)
        {
            base.firstName = firstName;
            this.lastName = lastName;
        }

        //public new void printFullName()
        //{
        //    //base.printFullName();
        //    Console.WriteLine("ParmanentEmployee - {0} {1}", this.firstName, this.lastName);
        //}

        public override void printFullName()
        {
            Console.WriteLine("ParmanentEmployee - {0} {1}", this.firstName, this.lastName);
        }

    }


    class TemporaryEmployee : Employee
    {
        double HourlyRate;
        public TemporaryEmployee()
             : base("No First Name", "No Last Name")
        {

        }

        public TemporaryEmployee(string firstName, string lastName)
        {
            base.firstName = firstName;
            this.lastName = lastName;
        }

        //public new void printFullName()
        //{
        //    //base.printFullName();
        //    Console.WriteLine("ParmanentEmployee - {0} {1}", this.firstName, this.lastName);
        //}

        public override void printFullName()
        {
            Console.WriteLine("TemporaryEmployee - {0} {1}", this.firstName, this.lastName);
        }

    }

    class Employee : EmployeeBase
    {
        private string firstName;
        public string lastName;

        private double salary;

        public double Salary
        {
            get
            {
                return salary;
            }
            //set
            //{
            //    if (value > 0)
            //    {
            //        salary = value;
            //    }
            //    else
            //    {
            //        salary = 0;
            //    }
            //}
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }


        public string LastName { get; set; }

        //public string getFirstName()
        //{
        //    return firstName;
        //}


        //public void setFirstName(string firstName)
        //{
        //    this.firstName = firstName;
        //}

        public Employee()
            : this("No First Name", "No Last Name")
        {

        }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override void printFullName()
        {
            Console.WriteLine("Employee - {0} {1}", this.firstName, this.lastName);
        }


    }

    abstract class EmployeeBase
    {
        public abstract void printFullName();
    }
}
