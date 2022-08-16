using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prg2_1
{
    internal class check
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
                Console.WriteLine("Not Eligible for Vote");
            else
                Console.WriteLine("Eligible for Vote");
            Console.ReadLine();
        }
    }
}
