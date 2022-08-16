using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3_11_square_
{
    internal class Number
        // wap to create a function to square a number
    {
        static void square()
        {
            int num = 5;
            int sq = num * num;
            Console.WriteLine("square = " + sq);
        }
        static void Main(string[] args)
        {
            square();
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
       
    }
}
