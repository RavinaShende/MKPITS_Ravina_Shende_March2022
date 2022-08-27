using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass12_printtable_doWhile_
{
    internal class Table
    {
        static void Main(string[] args)
        {
            //wap to accept no &  print the table using do while
            int num;
            int res = 1;
            Console.WriteLine("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());

            int i = 1;
            do
            {
                res = num * i;
                Console.WriteLine("{0}*{1}={2}",num,i,res);
                i++;
            } while (i <= 10);
            Console.ReadLine();
        }
    }
}
