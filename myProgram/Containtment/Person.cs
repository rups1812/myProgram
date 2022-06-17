using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Containtment
{

    class Address
    {
        int pincode;
        string city;

        public int Pincode
        {
            get { return pincode; }
            set { pincode = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
     
    }
    class Person
    {
        int id;
        string name;
        Address adr;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Address Adr
        {
            get { return adr; }
            set { adr = value; }
        }

    }

    class PersonInfo
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Id = 401;
            p.Name = "Akash";
            p.Adr = new Address();

            p.Adr.Pincode = 411015;
            p.Adr.City = "Pune";

            Console.WriteLine(p.Id+" "+p.Name+" "+p.Adr.Pincode+" "+p.Adr.City);
        }
    }
}
