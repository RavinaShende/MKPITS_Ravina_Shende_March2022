using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass14_primeno_
{
    internal class Primeno
    {
        static void Main(string[] args)
        {
            //wap to accept a number and print whether it is prime no. or not.
            int num, i,m=0;
           
            Console.WriteLine("Enter Number :");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    m = m + 1;
                }
            }
            if (m == 2)
                Console.WriteLine(num + " is a prime number");
            else
                Console.WriteLine(num + " is not a prime number");

            Console.ReadLine();

        }
    }
}
