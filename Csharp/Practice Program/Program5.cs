using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to accept radius of circle & display area & circumference
            int radius;
            Console.WriteLine("Enter radius of circle");
            radius = Convert.ToInt32(Console.ReadLine());
            float area = 3.14f * radius * radius;
            Console.WriteLine("Area of Circle = " + area);
            float circ = 2 * 3.14f * radius;
            Console.WriteLine("Circumference of circle =" + circ);
            Console.ReadLine(); 
        }
    }
}
