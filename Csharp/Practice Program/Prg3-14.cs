using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3_14_w_a_w_r_
{
    internal class Program
    {
        //Method with parameter & return type
        static int square(int num)
        {
            int sq = num * num;
            return sq;
        }
        static void Main(string[] args)
        {
            int num = 5;
            int res = square(num);
            Console.WriteLine("Square = " + res);
            Console.ReadLine();
        }
    }
}
