using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prg18_3
{
    using First;
    using Second;
    namespace First
    {
        public class Hello
        {
            public void sayHello()
            {
                Console.WriteLine("Hello Namespace");
            }
        }
    }
    namespace Second
    {
        public class Welcome
        {
            public void sayWelcome()
            {
                Console.WriteLine("Welcome Namespace");
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Hello h1 = new Hello();
            Welcome w1 = new Welcome();
            h1.sayHello();
            w1.sayWelcome();
            Console.ReadLine();
        }
    }
}
