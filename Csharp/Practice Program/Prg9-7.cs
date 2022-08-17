using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg9_7
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
            this.bookid = bookid;
            getdata(bookid, "html");
        }
        public void getdata(int bookid,string title)
        {
            this.bookid = bookid;
            this.title = title;
            getdata(bookid,title, "amitabh");
        }
        public void getdata(int bookid, string title, string author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            getdata(bookid, title, author, 234);
        }
        public void getdata(int bookid, string title, string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void displaydata()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("book author= " + author);
            Console.WriteLine("price = " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.getdata();
            b1.displaydata();
            Console.WriteLine("-----------------Book details---------------------------");
            Book b = new Book();
            b.getdata(899);
            b.displaydata();
            Console.ReadLine();
        }
    }
}
