using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.OOPS
{
    class Constructor
    {

        int x;
        int y;
        public Constructor():this(70)
        {
            Console.WriteLine("Default");

        }

        public void get(int y)
        {
            this.y = y;

        }

        public Constructor(int x)
        {
            Console.WriteLine("X = "+ x);

        }

        public void show()
        {
            this.get(50);
            Console.WriteLine(y);
        }


        static void Main(string[] args)
        {
            Constructor t = new Constructor();
            t.show();
        }

    }



    class Shopping
    {
        string purchaseitem;
        double price;
        int quantity;
        double bill;

        public void Accept(string spurchaseitem, double sprice, int squantity)
        {
            purchaseitem = spurchaseitem;
            price = sprice;
            quantity = squantity;
        }

        public void Getbill()
        {

            if(quantity>0)
            {
                bill = quantity * price;
                
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void Show()
        {
            Console.WriteLine("The item= "+ purchaseitem);
            Console.WriteLine("The item= " + price);
            Console.WriteLine("The item= " + quantity);
            Console.WriteLine("The bill of item= "+ bill);
        }

        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            s.Accept("Laptop", 50000, 0);
            s.Getbill();
            s.Show();
        }
    }

}
