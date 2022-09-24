using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg18_9
{
    internal class Program
    {
        static void display()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            display(); //to access static method display instance is not required
            Console.ReadLine();
        }
    }
}
