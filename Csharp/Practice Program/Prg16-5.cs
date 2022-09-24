using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//calling base class constructor internally
namespace Prg16_5
{
    class Person
    {
        string name = "MKPITS";
        public Person()
        {
            Console.WriteLine("person class constructor called");
        }
        public void display()
        {
            Console.WriteLine("base class field name = " + name);
        }
    }
    class Student : Person
    {
        string name = "Roshan";
        public Student()
        {
            Console.WriteLine("student class constructor called");
        }
        public void display()
        {
            //calling base class display method
            base.display();
            Console.WriteLine("child class field name = " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.display();
            Console.ReadLine();
        }
    }
}
