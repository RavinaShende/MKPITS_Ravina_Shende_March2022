using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_11_2D_array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a num array of 2 rows & 3 columns
            int[,] num = new int[2, 3];
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine("Enter num");
                    num[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //display array elements
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
