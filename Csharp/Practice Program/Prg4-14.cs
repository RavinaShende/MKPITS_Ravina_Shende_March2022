using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_14_clear_method_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 8, 5, 4, 7, 6, 3, 1, 2, 3 };
            Array.Clear(num, 0, 2);
            //display array elements
            for(int i=0;i<num.Length;i++)
            {
                Console.Write(num[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}
