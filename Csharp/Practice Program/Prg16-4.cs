using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg16_4
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public void eat()
        {
            base.eat(); //this will class base class method eat
            Console.WriteLine("Eating bread...");
        }
    }
    internal class TestBase
    {
        public static void Main(string[] args)
        {
            Dog g = new Dog();
            g.eat();
            Console.ReadLine();
        }
    }
}
