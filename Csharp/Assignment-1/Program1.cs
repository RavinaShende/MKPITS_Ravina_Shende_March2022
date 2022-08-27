using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2_addn_of_3nos_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to accept 3 nos & dispaly the addition of 3 nos
            int n1,n2,n3,res;
            Console.WriteLine("Enter number 1");
            n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            n2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            n3=Convert.ToInt32(Console.ReadLine());
            res = n1 + n2 + n3;
            Console.WriteLine("Addition of numbers = " + res);
            Console.ReadLine();
        }
    }
}
