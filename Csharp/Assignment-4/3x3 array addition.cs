using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass19_3x3_array_addition_
{
    //create 2 arrays of 3rows and 3 colums and then
    //create a third array to store addition of 2 array
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num1 = new int[3, 3];
            int[,] num2 = new int[3, 3];
            int[,] sum = new int[3, 3];
            Console.WriteLine("Enter array element 1:");
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    num1[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Enter array element 2:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    num2[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum[i, j] = num1[i, j] + num2[i,j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sum[i, j] + "\t");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
