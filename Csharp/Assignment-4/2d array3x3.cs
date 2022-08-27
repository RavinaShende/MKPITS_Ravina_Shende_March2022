using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass18_2d_array_3X3_
{
    //create a 2 d array of 3 rows and 3 colums
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] num = new int[3, 3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.WriteLine("Enter number :");
                    num[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                {
                    Console.Write(num[i,j] + "\t");
                }
                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
