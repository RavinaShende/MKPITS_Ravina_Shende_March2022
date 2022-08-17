using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_15_clone_method_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 5, 4, 7, 8 };
            int[] num1 = (int[])num.Clone();
            //display array element
            for(int i=0;i<num1.Length;i++)
            {
                Console.Write(num1[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}
