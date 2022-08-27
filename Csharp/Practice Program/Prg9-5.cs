﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class book having member variables bookid , title, author, and price 
//and a method getdata() with no parameters ,
//create another overloaded method getdata() with 4 parameters & method display

namespace Prg9_5_method_overloading_
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
        //method overload
        public void getdata(int bookid,string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book id = " + bookid);
            Console.WriteLine("Book title = "+title);
            Console.WriteLine("Book author = " + author);
            Console.WriteLine("Price = " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata();
            b.display();
            Console.WriteLine("------------------book1 details----------------");
            Book b1 = new Book();
            b1.getdata(111,"csharp","martin",2000);
            b1.display();

            Console.WriteLine("--------------------book2 details------------");
            Console.WriteLine("enter bookid");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            string title=Console.ReadLine();
            Console.WriteLine("enter author");
            string author=Console.ReadLine();
            Console.WriteLine("enter price");
            int price=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------Book3 details-----------------");
            Book b2 = new Book();
            b2.getdata(id,title,author,price);
            b2.display();
            Console.ReadLine();
        }
    }
}
