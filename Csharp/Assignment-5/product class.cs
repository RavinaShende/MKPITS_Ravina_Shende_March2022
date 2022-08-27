using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class product having fields prodid,prodname,prodrate,quantity
//and methods getproductdata and displayorder

namespace ass22_create_product_class_
{
    class Product
    {
        int prodid;
        string prodname;
        float prodrate;
        int quantity;

        public void productdata()
        {
            Console.WriteLine("Enter product id");
            prodid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product name");
            prodname = Console.ReadLine();
            Console.WriteLine("Enter product rate");
            prodrate = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter quantity");
            quantity = Convert.ToInt32(Console.ReadLine());
        }

        public void displayorder()
        {
            Console.WriteLine("Product id : " + prodid);
            Console.WriteLine("Product name :" + prodname);
            Console.WriteLine("Product rate :" + prodrate);
            Console.WriteLine("Product quantity :" + quantity);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1= new Product();
            p1.productdata();
            p1.displayorder();
            Console.ReadLine();
        }
    }
}
