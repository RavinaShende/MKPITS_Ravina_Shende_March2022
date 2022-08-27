using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_17_indexofmethod_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 6, 8, 7, 1, 4 };
            int l = Array.IndexOf(num, 2);
            Console.WriteLine("index " + l);
            Console.ReadLine();
        }
    }
}
