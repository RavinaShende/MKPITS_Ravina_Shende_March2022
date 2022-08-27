using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3_5
{
    internal class Factorial
    {
        static void Main(string[] args)
        {
            //wap to accept a number and print factorial of a number
            int num;
            int fact = 1;
            Console.WriteLine("Enter Number :");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial = " + fact);
            Console.ReadLine();
        }
    }
}
