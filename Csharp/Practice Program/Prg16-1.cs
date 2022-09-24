using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg16_1_Access_base_class_field_
{
    public class Animal
    {
        public string color = "white";
    }
    public class Dog : Animal
    {
        string color = "black";
        public void showColor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
    }
    internal class TestBase
    {
        public static void Main(string[] args)
        {
            Dog d = new Dog();
            d.showColor();
            Console.ReadLine();
        }
    }
}
