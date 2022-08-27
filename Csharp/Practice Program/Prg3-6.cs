using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3_6_foreachloop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example of foreach loop: create an array of 5 elements.
            int[] num = new int[3];
            num[0] = 33;
            num[1] = 22;
            num[2] = 11;
            //using foreach loop to iterate over the elements of an arra
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
