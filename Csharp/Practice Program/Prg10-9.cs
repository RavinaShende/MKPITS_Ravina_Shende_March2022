using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_9_protected_internal_A.S_
{
    class ProtectedTest
    {
        protected internal string name = "Shashikant";
        protected void Msg(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ProtectedTest test = new ProtectedTest();
            test.name = "Ravi";
            Console.WriteLine(test.name);
            Console.ReadLine();
        }
    }
}
