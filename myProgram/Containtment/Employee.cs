using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Containtment
{
    class Department
    {
        public int did;
        public string dname;

        public Department(int did, string dname)
        {
            this.did = did;
            this.dname = dname;

        }

        public void show()
        {
            Console.WriteLine(did + " " + dname);
        }

    }

    class Employee
    {
        int eid;
        string name;
        Department dept;

        Employee(int eid, string name, Department dept)
        {
            this.eid = eid;
            this.name = name;
            this.dept = dept;
        }

        void Display()
        {
            Console.WriteLine(eid + " " + name + " ");
            dept.show();
        }

        static void Main(string[] args)
        {
            Employee e = new Employee(101,"Rahul",new Department(201,"HR"));
            e.Display();
        }

    }
}
