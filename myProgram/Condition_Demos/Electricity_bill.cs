using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Condition_Demos
{
    class Electricity_bill
    {   

        static void Main(string[] args)
        {
            
            double amt, total_amt, sur_charge;
            Console.WriteLine("Enter total units consumed: ");
            int unit = int.Parse(Console.ReadLine());
            if (unit <= 50)
            {
                amt = unit * 0.50;
            }
            else if (unit <= 150)
            {
                amt = 25 + ((unit - 50) * 0.75);
            }
            else if (unit <= 250)
            {
                amt = 100 + ((unit - 150) * 1.20);
            }
            else
            {
                amt = 220 + ((unit - 250) * 1.50);
            }

            
            sur_charge = amt * 0.20;
            total_amt = amt + sur_charge;

            Console.WriteLine("Electricity Bill = {0}",  total_amt);
            


        }
    }   
}
