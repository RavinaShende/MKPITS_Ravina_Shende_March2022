using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_10
{
    class InternalTest
    {
        protected internal string name = "Santosh Kumar";
        protected internal void Msg(string msg)
        {
            Console.WriteLine("Hi " + msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            InternalTest test = new InternalTest();
            //accessing protected internal variable
            Console.WriteLine("Hello " + test.name);
            //accessing protected internal function
            test.Msg("Peter Decosta");
            Console.ReadLine();
        }
    }
}
