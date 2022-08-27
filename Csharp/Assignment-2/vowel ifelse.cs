using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass8_vowel_ifelse_
{
    internal class vowel
    {
        static void Main(string[] args)
        {
            //wap to accept character from the user & display whether it is vowel or not.(using if else)
            char ch;
            Console.WriteLine("Enter character");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a')
                Console.WriteLine(ch + " is a vowel");
            else if (ch == 'e')
                Console.WriteLine(ch + " is a vowel");
            else if (ch == 'i')
                Console.WriteLine(ch + " is a vowel");
            else if (ch == 'o')
                Console.WriteLine(ch + " is a vowel");
            else if (ch == 'u')
                Console.WriteLine(ch + " is a vowel");
            else
                Console.WriteLine(ch + " is not a vowel");

            Console.ReadLine();
            {

            }
        }
    }
}
