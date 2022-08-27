using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass8_1_vowel_switch_
{
    internal class vowel
    {
        static void Main(string[] args)
        {
            //wap to accept character from the user and display whether it is vowel or not.(using switch)
            char ch;
            Console.WriteLine("Enter character");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine(ch + " is a vowel");
                    break;
                case 'e':
                    Console.WriteLine(ch + " is a vowel");
                    break;
                case 'i':
                    Console.WriteLine(ch + " is a vowel");
                    break;
                case 'o':
                    Console.WriteLine(ch + " is a vowel");
                    break;
                case 'u':
                    Console.WriteLine(ch + " is a vowel");
                    break;
                default:
                    Console.WriteLine(ch + " is not a vowel");
                    break;
            }
            Console.ReadLine();
        }
    }
}
