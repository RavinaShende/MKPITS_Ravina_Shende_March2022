using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class book ,overload  method with 0 ,1 ,2,3,4 parameters.
namespace Prg9_6_create_class_book_overload_
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public void getdata()
        {
            bookid = 1;
            title = "oracle";
            author = "james";
            price = 200;
        }
        //method overloaded
        public void getdata(int bookid)
        {
            this.bookid= bookid;
        }
        public void getdata(int bookid,string title)
        {
            this.bookid = bookid;
            this.title = title;
        }
        public void getdata(int bookid, string title, string author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
        }
        public void getdata(int bookid, string title, string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " +title);
            Console.WriteLine("book author = "+author);
            Console.WriteLine("book price = "+price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Book1 details--------------------");
            Book b = new Book();
            b.getdata();
            b.display();
            Console.WriteLine("---------------Book2 details--------------------");
            Book b1=new Book();
            b1.getdata(111,"csharp");
            b1.display();
            Console.WriteLine("---------------Book3 details--------------------");
            Book b2 = new Book();
            b2.getdata(111, "csharp","james");
            b2.display();
            Console.WriteLine("---------------Book4 details--------------------");
            Book b3 = new Book();
            b3.getdata(111, "csharp","james",200);
            b3.display();
            Console.ReadLine();
        }
    }
}
