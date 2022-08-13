using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass10_totalamount_
{
    internal class Product
    {
        static void Main()
        {
            //wap to accept product name, product rate , quantity & display total amount
            string pname;
            int prate, pqty,total;
            Console.WriteLine("Enter Product Name:");
            pname = Console.ReadLine();
            Console.WriteLine("Enter Product Rate:");
            prate=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity:");
            pqty=Convert.ToInt32(Console.ReadLine());
            total = prate * pqty;
            Console.WriteLine("Total Amount = " + total);
            Console.ReadLine();
        }
    }
}
