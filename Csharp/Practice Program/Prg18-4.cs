using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Prg18_4_nested_namespace_
{
    using First;
    using First.Second;
    namespace First
    {
        public class Hello
        {
            public void sayHello()
            {
                Console.WriteLine("Hello first namespace");
            }
        }
        //creating a nested namespace
        namespace Second
        {
            public class Welcome
            {
                public void sayWelcome()
                {
                    Console.WriteLine("Hello second namespace");
                }
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Hello h1 = new Hello();
            h1.sayHello();
            Welcome w = new Welcome();
            w.sayWelcome();
            Console.ReadLine();
        }
    }
}
