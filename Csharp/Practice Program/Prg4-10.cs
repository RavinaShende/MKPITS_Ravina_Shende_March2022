using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_10_double_dimension_array_
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an array of 2 rows & 3 column
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 } };
            //Display the values of array
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
