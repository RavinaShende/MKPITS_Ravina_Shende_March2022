using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class cirlce having fields radius
//and method calculatearea and calculatecirc
namespace ass25_create_class_circle__
{
    class Circle
    {
        public int rad;
        public float area = 0;
        public float circ = 0;

        public void areadata()
        {
            area = 3.14f * rad * rad;
            Console.WriteLine("Area of circle = " + area);
        }
        public void circdata()
        {
            circ = 2 * 3.14f * rad;
            Console.WriteLine("Circ of circle = " + circ);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("Enter Radius of circle :");
            c1.rad=Convert.ToInt32(Console.ReadLine());
            c1.areadata();
            c1.circdata();
            Console.ReadLine();
        }
    }
}
