using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3_15_wo_a_w_r_
{
    internal class Program
    {
        //Method without parameter & with return type
        static int square()
        {
            int num = 5;
            int sq = num * num;
            return sq;
        }
        static void Main(string[] args)
        {
            int res = square();
            Console.WriteLine("Square = " + res);
            Console.ReadLine();
        }
    }
}
