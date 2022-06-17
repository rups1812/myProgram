using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Inheritance
{
    class Customer
    {
       public string buy = "Laptop";
    }

    class Shopper:Customer
    {
        public string sell = "Product";
    }

    class Distributor:Shopper
    {
        public string transport = "Various_items";


        public void show()
        {
            Console.WriteLine(buy+" "+sell+" "+transport+" ");
        }
    }
    class Multilevel_Inheritance
    {
        static void Main(string[] args)
        {
            Distributor d = new Distributor();
            d.show();
        }
    }





    class Buyer
    {
        public string Buy = "2bhk_flat";
    }

    class Broker:Buyer
    {
        public string Brokerage = "2% on the sale";
    }

    class Builder:Broker
    {
        public string Sale = "Flats";


        public void show()
        {
            Console.WriteLine(Buy+" "+Brokerage+" "+Sale+" ");
        }
    }


    class Multilevel
    {
        static void Main(string[] args)
        {
            Builder b = new Builder();
            b.show();
        }
    }
}
