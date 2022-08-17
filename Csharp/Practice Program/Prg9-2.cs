using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class book & constructor with no parameters & another constructor 4 parameters 
namespace Prg9_2_with_4_parameter_
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

        //creating a constructor with no parameter
        public Book()
        {
            Console.WriteLine("constructor with no parameter called ");
            bookid = 123;
            title = "vb.net";
            author = "roshan kumar";
            price = 12545;

        }
        //creating a parameterized constructor with 4 parameter
        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("constructor with parameters called");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void display()
        {
            Console.WriteLine("Book id : " + bookid);
            Console.WriteLine("title : " + title);
            Console.WriteLine("author : " + author);
            Console.WriteLine("price : " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(); //this will call constructor with no parameter automically
            b1.display();

            Book b2 = new Book(22, "oracle", "ashish",400); //this will called parameterized constructor
            b2.display();
            Console.ReadLine();
        }
    }
}
