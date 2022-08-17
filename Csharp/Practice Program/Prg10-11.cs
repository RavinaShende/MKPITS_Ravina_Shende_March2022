using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_11_private_access_specifier_
{
    class PrivateTest
    {
        private string name = "Santosh Kumar";
        private void Msg(string msg)
        {
            Console.WriteLine("Hi "+msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PrivateTest test = new PrivateTest();
            //accessing private variable
            Console.WriteLine("Hello " + test.name);
            //accessing private function
            test.Msg("Peter Decosta");
            Console.ReadLine();
        }
    }
}
