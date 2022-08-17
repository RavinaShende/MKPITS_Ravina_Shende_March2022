using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class book and constructor with no parameters and another constructor with 4 parameters
//with accepting values from the user
namespace Prg9_3
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        //creating a parameterized constructor with 4 parameters
        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("constructor with parameter called");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("author = " + author);
            Console.WriteLine("price = " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter bookid");
                int b1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter title");
                string t1=Console.ReadLine();
                Console.WriteLine("Enter author");
                string a1=Console.ReadLine();
                Console.WriteLine("Enter price");
                int p1=Convert.ToInt32(Console.ReadLine());
                Book b2 = new Book(b1, t1, a1, p1); //this wiil call parametrised constructor
                b2.display();
                Console.ReadLine();
        }
    }
}
