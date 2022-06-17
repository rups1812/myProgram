using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.OOPS
{
    class Employee
    {
        private int eid;
        private string name;
        private double salary;


        public int Eid
        {
            get { return eid;}
            set { eid = value;}
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }

    class EmployeeInfo
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Eid = 101;
            e.Name = "Rahul";
            e.Salary = 25000.45;

            Console.WriteLine(e.Eid+" "+ e.Name+" "+ e.Salary);
            
        }
    }


    class Student
    {
        private int sid;
        private string sname;
        private float spercentage;
        private bool splace;


        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }

        public string Sname
        {
            get { return sname; }
            set { sname = value; }
        }

        public float Spercantage
        {
            get { return spercentage; }
            set { spercentage = value; }
        }

        public bool Splace
        {
            get { return splace; }
            set { splace = value; }
        }
    }

    class StudentInfo
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Sid = 201;
            s.Sname = "Rupesh";
            s.Spercantage = 83;
            s.Splace = true;

            Console.WriteLine(s.Sid+" "+s.Sname+" "+s.Spercantage+" "+s.Splace);


            
            
        }
    }
}
