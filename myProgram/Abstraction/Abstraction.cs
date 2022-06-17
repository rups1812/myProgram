using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Abstraction
{
    abstract class TV
    {
        public abstract void show();
    }

    class Samsung : TV
    {
        public override void show()
        {
            Console.WriteLine("This is samsung TV");
        }
    }

    class Sony : TV
    {
        public override void show()
        {
            Console.WriteLine("This is sony TV");
        }

    }

    class Oneplus : TV
    {
        public override void show()
        {
            Console.WriteLine("This is oneplus TV");
        }
    }


   
    class Abstraction
    {
        static void Main(string[] args)
        {
            Samsung s = new Samsung();
            s.show();
            
            Sony n = new Sony();
            n.show();
         
            Oneplus o = new Oneplus();
            o.show();
            
        }
    }
}
