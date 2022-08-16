using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // program on goto statement
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                goto even;
            Console.WriteLine(num + " is odd number");
            goto end;
        even:
            Console.WriteLine(num + " is even number. ");
            goto end;
        end:
            Console.WriteLine("bye");
            Console.ReadLine(); 
        }
    }
}
