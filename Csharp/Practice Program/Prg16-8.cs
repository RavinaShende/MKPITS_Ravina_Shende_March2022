using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg16_8
{
    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("drawing..");
        }
    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle..");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle..");
        }
    }
    internal class TestPolymorphism
    {
        public static void Main(string[] args)
        {
            Shape s;
            s = new Shape();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.ReadLine();
        }
    }
}
