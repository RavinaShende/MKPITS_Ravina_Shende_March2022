using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg16_3_calling_base_class_method_
{
    class Person
    {
        string name = "MKPITS";
        public void display()
        {
            Console.WriteLine("base class field name = " + name);
        }
    }
    class Student:Person
    {
        string name = "Roshan";
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
