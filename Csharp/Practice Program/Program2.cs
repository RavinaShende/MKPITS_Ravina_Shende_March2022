using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to accept a number & print the square of that number
            int num;
            Console.WriteLine("Enter any number");
            num = Convert.ToInt32(Console.ReadLine());//ToInt32 method will convert string to integer
            int square = num * num;
            Console.WriteLine("square =" + square);
            Console.ReadLine();

        }
    }
}
