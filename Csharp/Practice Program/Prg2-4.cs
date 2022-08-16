using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg2_4
{
    internal class Opretr
    { 

        static void Main()
        {
            //wap to accept 2 no & enter operater like +,-,* & display the result
            int n1, n2, res=0;
            char op;
            Console.WriteLine("Enter 2 number");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operater like +, -, *");
            op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    res = n1 + n2;
                    break;
                case '-':
                    res = n1 - n2;
                    break;
                case '*':
                    res = n1 * n2;
                    break;
                default:
                    Console.WriteLine("Invalid Operater");
                    break;
            }
            Console.WriteLine("Result = " + res);
            Console.ReadLine();
        }
    }
}
