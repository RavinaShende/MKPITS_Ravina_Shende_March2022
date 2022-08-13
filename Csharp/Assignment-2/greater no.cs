using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass3_greater_no._
{
    internal class greater
    {
        static void Main(string[] args)
        {
            //wap to accept 2nos & print Greater no.
            int n1, n2;
            Console.WriteLine("Enter number 1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
                Console.WriteLine(n1 + "n1 is greater");
            else if (n2 > n1)
                Console.WriteLine(n2 + " is greater");
            else
                Console.WriteLine("Both numbers are equal");

            Console.ReadLine();
        }
    }
}
