using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg16_9
{
    public class Animal
    {
        public string color = "white";
    }
    public class Dog:Animal
    {
        public string color = "black";
    }

    internal class TestSealed
    {
        public static void Main(string[] args)
        {
            Animal d = new Dog();
            Console.WriteLine(d.color);
            Dog d1 = new Dog();
            Console.WriteLine(d1.color);
            Console.ReadLine();
        }
    }
}
