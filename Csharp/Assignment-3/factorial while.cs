using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass13_Fact_while_
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            //wap to accept no & calculate factorial
            int num, i=1;
            int fact = 1;
            Console.WriteLine("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());
            while(i <= num)
            {
                fact = fact * i;
                i++;
            }
            Console.WriteLine("Factorial = " + fact);
            Console.ReadLine();
        }
    }
}
