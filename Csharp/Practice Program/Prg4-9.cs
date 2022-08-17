using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_9_array_initialization_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create num array of 5 element
           // int[] num = new int[5] {8,8,8,8,8};
            int[] num = { 1, 2, 3, 4, 5 };
            //display array elements
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("num [{0} = {1}]", i, num[i]);
            }
            Console.ReadLine();
        }
    }
}
