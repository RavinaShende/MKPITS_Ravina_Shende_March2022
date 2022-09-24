using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg16_7_polymorphism_
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating..");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("eating bread...");
        }
    }
    internal class TestPolymorphism
    {        
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.eat();
            Console.ReadLine();
        }
    }
}
