using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3_10_user_define_
{
    internal class User_define_func
    {
        static void display()
        {
            Console.WriteLine("Hello from display function");
        }
        static void Main(string[] args)
        {
            //wap to create a display function w/o parameter
            display();
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
