using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass10_1_totalamount_disc._
{
    internal class Product
    {
        static void Main()
        {
            //wap to accept product name, product rate, quantity & calculate totalamount,
            //discount ie 50 % if totalamount > 2000,else discount = 10 % of total amount
            //using if-else
            string pname;
            int prate, pqty, total;
            Console.WriteLine("Enter Product Name:");
            pname = Console.ReadLine();
            Console.WriteLine("Enter Product Rate:");
            prate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity:");
            pqty = Convert.ToInt32(Console.ReadLine());
            total = prate * pqty;
            Console.WriteLine("Total Amount = " + total);
            float disc = 0;
            if (total > 2000)
                disc = (total * 50)/100;
            else
                disc = (total * 10) / 100;


            float tamt = total - disc;
            Console.WriteLine("Payable amount = " + tamt);
            Console.ReadLine();
        }
    }
}
