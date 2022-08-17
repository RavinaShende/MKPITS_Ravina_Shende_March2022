using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_2_passbyvalue_
{
    internal class Program
    {
        static void display(int num)
        {
            num++;
            Console.WriteLine("Num inside method " + num);
        }
        static void Main(string[] args)
        {
            int num = 5;
            display(num);
            Console.WriteLine("Num inside main " +num);
            Console.ReadLine();
        }
    }
}
