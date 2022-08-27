using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3_12
{
    internal class Program

        //Function w/o arg, no return type
    {
        void square()
        {
            int num = 5;
            int sq = num * num;
            Console.WriteLine("square = " +sq);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.square();//Calling the method display
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
