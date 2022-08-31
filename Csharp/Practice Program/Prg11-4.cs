using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg11_4
{
    //create base class
    class Person
    {
        public string name;
        public string address;
    }
    //create derived class
    class Student : Person
    {
       public int rno;
       public int marks;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student p1 = new Student();
            p1.rno = 123;
            p1.name = "Amit";
            p1.address = "Pune";
            p1.marks = 569;

            Console.WriteLine("Roll no : " + p1.rno);
            Console.WriteLine("Name : " + p1.name);
            Console.WriteLine("Address : " + p1.address);
            Console.WriteLine("Marks : " + p1.marks);
            Console.ReadLine();
        }
    }
}
