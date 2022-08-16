using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to accept 2 no & print the addition of numbers
            int num1, num2, res;
            Console.WriteLine("enter number 1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            num2=Convert.ToInt32(Console.ReadLine());
            res = num1 + num2;
            Console.WriteLine("addition =" + res);
            Console.ReadLine();
        }
    }
}
