using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_8_1D_array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a num array of 5 elements
            int[] num = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter number");
                num[i]=Convert.ToInt32(Console.ReadLine());
            }
            //display the values of array
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("num[{0}] = {1}", i, num[i]);
            }
            Console.ReadLine();
        }
    }
}
