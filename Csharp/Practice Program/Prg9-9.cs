using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg9_9
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        //method overloaded
        public void getdata(int bookid, string title,string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void getdata(int bookid,int price,string title,string author)
        {
            this.bookid=bookid;
            this.title=title;
            this.author=author;
            this.price = price;
        }
        public void getdata(string author, int bookid, int price, string title)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
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
            Console.WriteLine("-----------------book details--------------");
            Book b = new Book();
            b.getdata(1, "html", "abc", 1200);
            b.display();
            Console.WriteLine("-----------------book details--------------");
            Book b1 = new Book();
            b1.getdata(1,1200,"html", "abc");
            b1.display();
            Console.WriteLine("-----------------book details--------------");
            Book b2 = new Book();
            b2.getdata("html",1, 1200,"abc");
            b2.display();
            Console.ReadLine();
        }
    }
}
