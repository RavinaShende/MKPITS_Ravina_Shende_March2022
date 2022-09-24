using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_11
{
    public interface Drawable
    {
        void draw();
    }
    public class Rectangle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Drawable d;
            d = new Rectangle();
            d.draw();
            d = new Circle();
            d.draw();
            Console.ReadLine();
        }
    }
}
