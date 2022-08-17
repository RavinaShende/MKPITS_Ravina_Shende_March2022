using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_4_example_of_out_
{
    internal class Program
    {
        static void display(out int num)
        {
            num = 5;
            Console.WriteLine("num inside method " + num);//5
        }
        static void Main(string[] args)
        {
            int num;
            display(out num);
            Console.WriteLine("num inside main " + num);//5
            Console.ReadLine();
        }
    }
}
