using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass5_smallest_no_
{
    internal class smallest
    {
        static void Main(string[] args)
        {
            //wap to accept 3 nos & print smallest no.
            int n1, n2, n3;
            Console.WriteLine("Enter 3 different numbers :");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 < n2 && n1 < n3)
                Console.WriteLine(n1 + " is smallest number");
            else if (n2 < n1 && n2 < n3)
                Console.WriteLine(n2 + " is smallest number");
            else  (n3 < n1 && n3 < n2)
                Console.WriteLine(n3 + " is smallest number");

            Console.ReadLine();
        }
    }
}
