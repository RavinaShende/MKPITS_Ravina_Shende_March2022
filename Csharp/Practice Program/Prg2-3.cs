using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg2_3
{
    internal class operater
    {
        static void Main(string[] args)
        {
            //wap to accept 2 nos & operator like +,-,* & display the result
            int n1, n2, res = 0;
            char op;
            Console.WriteLine("Enter any 2 number :");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operater like +,-,*");
            op = Convert.ToChar(Console.ReadLine());
            if (op == '+')
                res = n1 + n2;
            else if (op == '-')
                res = n1 - n2;
            else if (op == '*')
                res = n1 * n2;
            else
                Console.WriteLine("Invalid Operator");
            Console.WriteLine("Result = " + res);

            Console.ReadLine();
        }
    }
}
