using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass13_Fact_dowhile_
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("Enter Number :");
            num = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            do
            {
                fact = fact * i;
                i++;
            } while (i <= num);
            Console.WriteLine("Factorial = " + fact);
            Console.ReadLine();
        }
    }
}
