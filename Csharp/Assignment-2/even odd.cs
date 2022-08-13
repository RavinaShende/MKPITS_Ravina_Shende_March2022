using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass7_even_odd_
{
    internal class evenodd
    {
        static void Main(string[] args)
        {
            //wap to accept a no. & print wheather it is even or odd no.
            int num;
            Console.WriteLine("Enter any number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine(num + " is even number");
            else
                Console.WriteLine(num + " is odd number");

            Console.ReadLine();
        }
    }
}
