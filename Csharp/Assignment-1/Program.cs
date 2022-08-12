using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1_area_of_rect._
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to accept length & breath ,& display the area of rectangle
            int length, breath, result;
            Console.WriteLine("Enter Length");
            length=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breath");
            breath=Convert.ToInt32(Console.ReadLine());
            result = length * breath;
            Console.WriteLine("Area of rectangle =" + result);
            Console.ReadLine();
        }
    }
}
