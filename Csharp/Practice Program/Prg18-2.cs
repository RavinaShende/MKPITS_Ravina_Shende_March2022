using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg18_2
{
    namespace first
    {
        public class Hello
        {
            public void sayHello()
            {
                Console.WriteLine("Hello From First Namespace");
            }
        }
    }
    namespace second
    {
        public class Hello
        {
            public void sayHello()
            {
                Console.WriteLine("Hello from second namespace");
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            first.Hello h1 = new first.Hello();
            second.Hello h2 = new second.Hello();
            h1.sayHello();
            h2.sayHello();
            Console.ReadLine();
        }
    }
}
