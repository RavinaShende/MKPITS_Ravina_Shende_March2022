using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg16_6
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("animal..");
        }
    }
    public class Dog:Animal
    {
        public Dog()
        {
            Console.WriteLine("dog..");
        }
    }

    internal class TestOverriding
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            Console.ReadLine();
        }
    }
}
