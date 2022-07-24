using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Collection
{
    class Assignment_1to20
    {
        static void Main(string[] args)
        {
            List<int> numberlist = new List<int>();

            numberlist.Add(20);
            numberlist.Add(40);
            numberlist.Add(60);
            numberlist.Add(80);
            numberlist.Add(100);

            

            foreach (int data in numberlist)
            {
                Console.WriteLine(data);
            }

            List<string> stringlist = new List<string>();

            stringlist.Add("Akash");
            stringlist.Add("Rahul");
            stringlist.Add("Paresh");
            stringlist.Add("Vedant");
            stringlist.Add("Darshan");

            foreach(string s in stringlist)
            {
                Console.WriteLine(s);
            }

        }
    }

    class Position
    {
        static void Main(string[] args)
        {
            List<Object> ob = new List<object>();

            ob.Add(20);
            ob.Add("Rupesh");


            int idx1 = ob.IndexOf(20);
            int idx2 = ob.IndexOf("Rupesh");
            Console.WriteLine(idx1);
            Console.WriteLine(idx2);

            foreach(object o in ob)
            {
                Console.WriteLine(o);
            }
        
        }
    }

    class Color_string
    {
        static void Main(string[] args)
        {
            List<string> list_Strings = new List<string>();

            list_Strings.Add("Red");
            list_Strings.Add("Green");
            list_Strings.Add("Orange");
            list_Strings.Add("White");
            list_Strings.Add("Black");


            foreach(string s in list_Strings)
            {
                Console.WriteLine(s);
            }
        }
    }

    
    class List_swap
    {   
        static void Main(string[] args)
        {
            List<int> lst = new List<int>() { 1, 2, 3, 4, 5 };


            Console.WriteLine("Before Swaping= "+lst[1]);
            Console.WriteLine("Before Swaping= " +lst[3]);

            lst[0] = lst[1];
            lst[1] = lst[3];
            lst[3] = lst[0];

            Console.WriteLine("After Swaping= "+lst[1]);
            Console.WriteLine("After Swaping= " +lst[3]);
            
        }
    }


    class List_replace
    {
        static void Main(string[] args)
        {
            List<string> ss = new List<string>();

            ss.Add("A");
            ss.Add("B");
            ss.Add("C");
            ss.Add("D");
            ss.Add("E");
            ss.Add("F");

            foreach(string data in ss)
                Console.WriteLine(data);

            Console.WriteLine("....................................");

            ss.Insert(2, "Z");
            

            foreach(string st in ss)
                Console.WriteLine(st);

        }
    }


    class Studentlst
    {
        string name;
        string std;
        int marks;
        string gender;

        public Studentlst(string name, string std, int marks, string gender)
        {
            this.name = name;
            this.std = std;
            this.marks = marks;
            this.gender = gender;
        }

        public override string ToString()
        {
            return "Name= " + name + "Standard= " + std + "Marks= " + marks + "Gender= " + gender;
        }


        public string Name { get => name; set => name = value; }
        public string Std { get => std; set => std = value; }
        public int Marks { get => marks; set => marks = value; }
        public string Gender { get => gender; set => gender = value; }
    }


    class Students_list
    {
        static void Main(string[] args)
        {
            List<Studentlst> slist = new List<Studentlst>();

            slist.Add(new Studentlst("Ajinkya","NINE", 98, "male"));
            slist.Add(new Studentlst("Rahul", "FIVE", 92, "male"));
            slist.Add(new Studentlst("Paresh", "SEVEN", 90, "male"));
            slist.Add(new Studentlst("Vedant", "EIGHT", 80, "male"));
            slist.Add(new Studentlst("Darshan", "SIX", 95, "male"));
            slist.Add(new Studentlst("Akash", "TEN", 88, "male"));

            

            foreach(Studentlst st in slist)
                if (st.Marks > 90) {
                    Console.WriteLine(st);
                }
                
        }
    }


    class ArrayToList
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            List<int> lst = array.ToList();

            foreach(int data in lst)
                Console.WriteLine(data);
        }
    }

    class ReverseList
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>() { "rupesh", "akash", "Sam", "Darshan" };
            
            lst.Reverse();
            foreach (string s in lst)
            {
                Console.WriteLine(s + " ");
            }
        }
    }

    class SortList
    {
        static void Main(string[] args)
        {
            List<string> slst = new List<string>() { "Vedant", "Rajesh", "Kapil", "Ajay", "Bhavesh" };

            slst.Sort();

            foreach(string ss in slst)
                Console.WriteLine(ss);
        }
    }


    class Employee:IComparable<Employee>
    {
        string name;
        string designation;
        int age;

        public Employee(string name, string designation, int age)
        {
            this.name = name;
            this.designation = designation;
            this.age = age;
        }

        public override string ToString()
        {
            return "Name= " + name + "  Designation= " + designation + " Age= " + age;
        }
        public int CompareTo(Employee other)
        {
            return other.age.CompareTo(this.age);
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Age { get => age; set => age = value; }
    }

    class EmpList
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>();

            emp.Add(new Employee("Rupesh", "jr Engg", 25));
            emp.Add(new Employee("Ajinkya", "CEO", 24));
            emp.Add(new Employee("Akash", "HR", 22));
            emp.Add(new Employee("Rakesh", "Design engg", 28));
            emp.Add(new Employee("Paresh", "Marketing", 23));

            emp.Sort();

            emp.ForEach(e1 => Console.WriteLine(e1));

            Dictionary<Employee, object> dictionaryEmp = new Dictionary<Employee, object>();

           
        }
    }


    class DemoDictonary
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();

            d.Add(25, "Rupesh");
            d.Add(24, "Ajinkya");
            d.Add(26, "Vaibhav");
            d.Add(22, "Darshan");


            foreach(KeyValuePair<int, string> kv in d)
                Console.WriteLine(kv.Key +"==>"+ kv.Value);
            Console.WriteLine("_____________________________________");

            Dictionary<string, int> dd = new Dictionary<string, int>();

            dd.Add("Rupesh", 25);
            dd.Add("Darshan", 22);
            dd.Add("Ajinkya", 24);
            dd.Add("Vaibhav", 26);

            

            foreach(KeyValuePair<string, int> kp in dd)
                Console.WriteLine(kp.Key +"==>"+ kp.Value);

        }
    }



    class KeyOnly
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();

            dd.Add("Rupesh", 25);
            dd.Add("Darshan", 22);
            dd.Add("Ajinkya", 24);
            dd.Add("Vaibhav", 26);


            List<string> keys = dd.Keys.ToList();

            foreach(string s in keys)
                Console.WriteLine(s);


        }
    }


    class ValueOnly
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dd = new Dictionary<string, int>();

            dd.Add("Rupesh", 25);
            dd.Add("Darshan", 22);
            dd.Add("Ajinkya", 24);
            dd.Add("Vaibhav", 26);

            List<int> values = dd.Values.ToList();

            foreach(int ss in values)
                Console.WriteLine(ss);
        }
    }

    public class Student
    {

        string name;
        int marks;
        int age;

        public Student(string name, int marks, int age)
        {
            this.name = name;
            this.marks = marks;
            this.age = age;
        }


        public override string ToString()
        {
            return "Name= " + name + " Marks= " + marks + " Age= " + age;
        }

        public string Name { get => name; set => name = value; }
        public int Marks { get => marks; set => marks = value; }
        public int Age { get => age; set => age = value; }
    }



    class CustomDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<Student, object> c = new Dictionary<Student, object>();

            var obj =new { mobileno = 9875878595 };
            var obj2 = new { address = "Dighi" };

            c.Add(new Student("Rupesh", 95, 25), obj);
            c.Add(new Student("Akash", 95, 22), obj2);

            foreach (KeyValuePair<Student, object> kv in c)
                Console.WriteLine(kv.Key+" "+kv.Value);
        }   
    }


    class QueueDemo
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(101);
            q.Enqueue(201);
            q.Enqueue(301);
            q.Enqueue(401);
            q.Enqueue(501);

            foreach(int e in q)
                Console.WriteLine(e);
            Console.WriteLine("*********************************");
            q.Dequeue();
            q.Dequeue();

            foreach(int ee in q)
                Console.WriteLine(ee);
        }
    }


    class Stack_Demos
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();

            st.Push(101);
            st.Push(201);
            st.Push(301);
            st.Push(401);
            st.Push(501);


            st.Pop();

            foreach(int s in st)
                Console.WriteLine(s);
            Console.WriteLine("****************");

            Console.WriteLine( st.Peek()); 

            

        }
    }


    class HashsetDemo
    {
        static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>();

            hs.Add(101);
            hs.Add(201);
            hs.Add(401);
            hs.Add(601);
            hs.Add(801);
            hs.Add(301);

            foreach (int ht in hs)
                Console.WriteLine(ht);
        }
    }


    class SortedDemo:IComparable<SortedDemo>
    {

        string empname;
        long salary;

        public SortedDemo(string empname, long salary)
        {
            this.empname = empname;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "EmpName= " + empname + " Salary= " + salary;

        }

        public int CompareTo(SortedDemo other)
        {
            return this.salary.CompareTo(other.salary);
        }

        public string Empname { get => empname; set => empname = value; }
        public long Salary { get => salary; set => salary = value; }

        
    }

    class Sortedlist
    {
        static void Main(string[] args)
        {
            SortedList<SortedDemo, string> sl = new SortedList<SortedDemo, string>();

            sl.Add(new SortedDemo("Rupesh", 30000), "Mech");
            sl.Add(new SortedDemo("Ajinkya", 15000), "IT");
            sl.Add(new SortedDemo("Paresh", 25000), "Comp");
            sl.Add(new SortedDemo("Vedant", 45000), "ENTC");
            sl.Add(new SortedDemo("Darshan", 55000), "Civil");


            foreach (KeyValuePair<SortedDemo, string> Kv in sl)
            {
                Console.WriteLine(Kv.Key + "==>" + Kv.Value);
            }


        }
    }


}
