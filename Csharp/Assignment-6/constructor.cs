using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class product having fields productid,productname,price & quantity
//create a constructor with no parameters & method display
namespace ass1_constructor_
{
    class Product
    {
        int productid, quantity;
        string productname;
        float price;
        //creating a constructor with no parameters
        public Product()
        {
            productid = 1;
            productname = "Fruits";
            price = 20.56f;
            quantity = 10;
        }
        public void display()
        {
            Console.WriteLine("Product Id = " + productid);
            Console.WriteLine("Product Name = " + productname);
            Console.WriteLine("Price = " + price);
            Console.WriteLine("Quantity = " + quantity);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.display();
            Console.ReadLine();
        }
    }
}
