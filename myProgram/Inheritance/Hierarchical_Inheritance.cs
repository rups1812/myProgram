using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Inheritance
{

    class Newspaper
    {
        public string news = "Information";
    }

    class Times_of_India : Newspaper
    {
        public string price = "5 Rupees";
    }

    class Hindustan_Times:Newspaper
    {
        public string pages = "8 pages";

    }

    class The_Indian_Express:Newspaper
    {
        public string print = "Black print";
    }


    class Hierarchical_Inheritance
    {
        static void Main(string[] args)
        {
            Times_of_India t = new Times_of_India();
            Console.WriteLine(t.news+" "+t.price);
            Hindustan_Times h = new Hindustan_Times();
            Console.WriteLine(h.news+" "+h.pages);
            The_Indian_Express i = new The_Indian_Express();
            Console.WriteLine(i.news+" "+i.print);

        }
    }


    class TV
    {
        public string Type = "Company name";
    }

    class Samsung:TV
    {
        public int modelno = 4458;
        public string Screen = "LED";
    }

    class Sony:TV
    {
        public int modelno = 2256;
        public string Screen = "LCD IPS";
    }

    class Oneplus:TV
    {
        public int modelno = 6678;
        public string Screen = "OLED";
    }


    class Heirarchical
    {
        static void Main(string[] args)
        {
            Samsung s = new Samsung();
            Console.WriteLine(s.Type+" "+s.modelno+" "+s.Screen);
            Sony n = new Sony();
            Console.WriteLine(n.Type+" "+n.modelno+" "+n.Screen);
            Oneplus o = new Oneplus();
            Console.WriteLine(o.Type+" "+o.modelno+" "+o.Screen);
        }
    }
   
}
