using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg11_5
{
    //create a base class
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating..");
        }
    }
    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking..");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.eat();
            d1.bark();
            Console.ReadLine();
        }
    }
}
