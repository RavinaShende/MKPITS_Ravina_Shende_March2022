using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass12_printtable_while_
{
    internal class Table
    {
        static void Main()
        {
            //wap to accept number & print a table using while loop
            int num;
            int res = 0;
            Console.WriteLine("Enter number :");
            num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while( i <= 10)
            {
                res = num * i;
                Console.WriteLine("{0} * {1} = {2}", num, i, res);
                i++;
            }
            Console.ReadLine();
        }
    }
}
