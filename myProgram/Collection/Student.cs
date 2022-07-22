using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Collection
{
    class Student:IComparable<Student>
    {
        string name;
        int percent;
        string qualification;

        public Student(string name, int percent, string qualification)
        {
            this.Name = name;
            this.Percent = percent;
            this.Qualification = qualification;
        }

        public override string ToString()
        {
            return "Name= " + name + " Percentage= " + percent + " Qualification= " + qualification;
        }

        public int CompareTo(Student other)
        {
            return this.name.CompareTo(other.name);
        }

        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public string Qualification { get => qualification; set => qualification = value; }
    }

    class Properties
    {
        static void Main(string[] args)
        {
            List<Student> slist =new List<Student>();
            slist.Add(new Student("Ajinkya", 90, "BE"));
            slist.Add(new Student("Sujal", 93, "BE"));
            slist.Add(new Student("Eshan", 91, "BE"));
            slist.Add(new Student("Kunal", 85, "BE"));
            slist.Add(new Student("Ajit", 88, "BE"));

            slist.Sort();

            slist.ForEach(s1 => Console.WriteLine(s1));

           /* List<Student> st = slist.FindAll(sobj => sobj.Percent > 90);
            foreach(Student s in slist)
            {
                if(s.Percent>90)
                    Console.WriteLine(s);
            }*/
        }
    }
}
