using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_16_getlength_method_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 8, 9, 7, 5, 1 };
            int num1 = num.GetLength(0);
            Console.WriteLine("Length " + num1);
            Console.ReadLine();
        }
    }
}
