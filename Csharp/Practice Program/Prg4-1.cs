using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_1
{
    internal class Variable
    {
       static int gnum = 6;
        static void display()
        {
            int num = 5;
            Console.WriteLine("num inside method " +  num);
            Console.WriteLine("gnum inside method " + gnum);
        }
        static void Main(string[] args)
        {
            display();
           // Console.WriteLine("num = " + num );
            Console.WriteLine("gnum inside main " + gnum);
            Console.ReadLine();
        }
    }
}
