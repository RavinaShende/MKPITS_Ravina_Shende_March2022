using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_10_interface_
{
    interface Shape
    {
        void draw();
    }
    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("draw method of rectangle class");
        }
    }
    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("draw method of circle class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.ReadLine();
        }
    }
}
