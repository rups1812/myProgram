using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProgram.StringDemos
{
    class Average_string
    {
        public static int checkavg(string s)
        {
            int sum = 0;
            int avg = 0;
            
            int count = 0;

            for(int i=0; i<s.Length; i++)
            {
                if(s[i]>='0' && s[i]<='9')
                {
                    int x = (int)char.GetNumericValue(s[i]);
                    sum = sum + x;
                    count++;
                }
                
            }
            
            avg = sum / count;
            Console.WriteLine("sum= " + sum + " count= " + count); 
            return avg;
            
        }       
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string str = Console.ReadLine();
            int avg = Average_string.checkavg(str);
            Console.WriteLine(avg);

        }
    }
}
