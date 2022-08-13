using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass6_prime_no_
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            //wap to accept a number & print wheather it is prime or not
            int num,i,m=0;
            Console.WriteLine("Enter any number : ");
            num = Convert.ToInt32(Console.ReadLine());

            /*if (num % 1 == 0 && num % num == 0)
                Console.WriteLine(num + " is prime number");
            else
                Console.WriteLine(num + " is not a prime number");*/
            for(i=1;i<=num;i++)
            {
                if(num % i == 0)
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
