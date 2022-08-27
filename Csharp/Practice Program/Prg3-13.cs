using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3_13_w_a_no_r_
{
    internal class Return

    {
        // Method with parameter & no return type
        static void square (int num)
        {
            int sq = num * num;
            Console.WriteLine ("Square = " + sq);
        }
        static void Main(string[] args)
        {
            int num = 5;
            square(num);//calling the method display
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
