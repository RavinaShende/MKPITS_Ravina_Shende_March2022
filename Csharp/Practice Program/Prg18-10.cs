using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg18_10
{
    class Student
    {
        public static void display()
        {
            Console.WriteLine("Hello");
        }
        public void sayhi()
        {
            Console.WriteLine("Hi");
        }
    }
    internal class Program
    {
        //creating nonstatic display method
        static void Main(string[] args)
        {
            Student.display();
            //Student.sayhi();//error
            Student s = new Student();
            s.sayhi();
            Console.ReadLine();
        }
    }
}
