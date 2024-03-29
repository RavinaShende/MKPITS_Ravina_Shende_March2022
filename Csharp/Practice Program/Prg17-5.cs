﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_5
{
    public abstract class Shape
    {
        public abstract void draw();
    }
    public class Rectangle :Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    internal class TestAbstract
    {
        public static void Main(string[] args)
        {
            Shape s;
            s=new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();
            Console.ReadLine();
        }
    }
}
