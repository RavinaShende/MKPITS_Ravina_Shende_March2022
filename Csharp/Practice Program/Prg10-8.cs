using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_8_internal_access_specifier_
{
    class InternalTest
    {
        internal string name = "Santosh Kumar";
        internal void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            InternalTest test = new InternalTest();
            //accessing internal variable
            Console.WriteLine("Hello " + test.name);
            //accessing internal function
            test.Msg("Peter Decosta");
            Console.ReadLine();
        }
    }
}
