using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg18_8_Static_
{
    internal class Program
    {
        void display()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.display();
            Console.ReadLine();
        }
    }
}
