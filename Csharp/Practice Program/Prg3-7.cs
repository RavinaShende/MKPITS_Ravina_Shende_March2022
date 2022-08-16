using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an array of 3 elements using foreach loop
            string[] num = new string[3];
            num[0] = "amit";
            num[1] = "raj";
            num[2] = "dilip";

            foreach(string i in num)
            {
                Console.WriteLine(i);   
            }
            Console.ReadLine();
        }
    }
}
