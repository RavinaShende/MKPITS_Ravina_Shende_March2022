using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_9_method_overrideing_
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating....");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }
    public class TestOverride
    {
        public static void Main(string[] args)
        {
            Animal d = new Dog();
            d.eat();
            Console.ReadLine();
        }
    }
}
