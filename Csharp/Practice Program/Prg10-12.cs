using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_12
{
    internal class Program
    {
        private string name = "santosh kumar";
        private void Msg(string msg)
        {
            Console.WriteLine("hi "+msg);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            //accessing private variable
            Console.WriteLine("Hello " + p.name);
            //accessing private function
            p.Msg("Peter Decosta");
            Console.ReadLine();
        }
    }
}
