using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg16_2
{
    class Person
    {
        public string name = "MKPITS";
    }
    class Student:Person
    {
        public string name = "Roshan";
        public void display()
        {
            Console.WriteLine("name = " + name); //Roshan
            Console.WriteLine("base class field name = " + base.name);
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
