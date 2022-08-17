using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_7
{
    internal class Program
    {
        //parameter with method overloading
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Add(int a,int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1,2,3));
            Console.ReadLine();
        }
    }
}
