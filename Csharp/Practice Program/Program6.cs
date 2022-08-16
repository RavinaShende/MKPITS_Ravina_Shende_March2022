using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to accept character from the user
            char ch;
            Console.WriteLine("Enter character");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Charater entered = " + ch);
            Console.ReadLine();
        }
    }
}
