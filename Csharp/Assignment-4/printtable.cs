using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass16_print_table_
{
    //Create a method to
    //accept a number and print the table of that number.
    internal class Program
    {
        static void PrintTable(int n)
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0}*{1}={2}",n,i,n*i);
            }
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number :");
            num=Convert.ToInt32(Console.ReadLine());
            PrintTable(num);
            Console.ReadLine();
        }
    }
}
