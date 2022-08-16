using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program8
{
    internal class Byte
    {
        static void Main(string[] args)
        {
            //Program on byte
            byte b1;
            Console.WriteLine("Enter Byte");
            b1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Byte Entered = " + b1);
            Console.ReadLine();
        }
    }
}
