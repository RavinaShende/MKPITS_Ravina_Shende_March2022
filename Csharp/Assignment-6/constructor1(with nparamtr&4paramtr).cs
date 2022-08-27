using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class product having fields prodid,prodname , prodrate
//and quantity , create a constructor with no parameters and
//create another parameterized constructor with 4 parameters


namespace ass31
{
    class Product
    {
        int prodid;
        string prodname;
        float prodrate;
        int quantity;

        //1-create a constructor with no parameter
        public Product()
        {
            prodid = 111;
            prodname = "Fruits";
            prodrate = 45.0f;
            quantity = 25;
        }
        //2-parameterized constructor with 4 parameters
        public Product(int prodid, string prodname, float prodrate, int quantity)
        {
            this.prodid = prodid;
            this.prodname = prodname;
            this.prodrate = prodrate;
            this.quantity = quantity;
        }
        public void display()
        {
            Console.WriteLine("Product no. :" + prodid);
            Console.WriteLine("Product name :" + prodname);
            Console.WriteLine("Product rate :" +prodrate);
            Console.WriteLine("Product quantity :" + quantity);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1= new Product();//this will call constructor automatically
            p1.display();
            Console.WriteLine("-----------------product details-----------------");
            Product p2 = new Product(35, "Mango", 15.0f, 15);//parameterized constructor
            p2.display();
            Console.WriteLine("-----------------product details-----------------");
            Console.WriteLine("Product no. :");
            int prodid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Product name & Product rate :");
            string prodname = Console.ReadLine();
            float prodrate = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Product quantity :");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------product details-----------------");
            Product p3 = new Product(prodid,prodname,prodrate,quantity);
            p3.display();
            Console.ReadLine();

        }
    }
}
