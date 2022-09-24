using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg18_14
{
    public static class MyMath
    {
        public static float PI = 3.14f;
        public static int cube(int n)
        {
            return n * n * n;
        } 
    }
    public class TestMyMath
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Value of PI is : " + MyMath.PI);
            Console.WriteLine("Cube of 3 is : " + MyMath.cube(3));
            Console.ReadLine();
        }
    }
}
