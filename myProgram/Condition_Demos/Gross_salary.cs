using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.Condition_Demos
{
    class Gross_salary
    {
        static void Main(string[] args)
        {
            
           

            double  da, hra, gross;
            Console.WriteLine("enter the basic salary of employee");
            int basic = int.Parse(Console.ReadLine());
     

            if (basic <= 10000)
            {
                da = basic * 0.8;
                hra = basic * 0.2;
            }
            else if (basic <= 20000)
            {
                da = basic * 0.9;
                hra = basic * 0.25;
            }
            else
            {
                da = basic * 0.95;
                hra = basic * 0.3;
            }

            
            gross = basic + hra + da;
            Console.WriteLine("The Gross Salary Will be={0}", gross);
            

        }
    }
}
