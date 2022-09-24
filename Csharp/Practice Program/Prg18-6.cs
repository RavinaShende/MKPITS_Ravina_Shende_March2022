using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg18_6
{
    class Person
    {
        public virtual void display()
        {
            Console.WriteLine("Hello from person");
        }
    }
    class Student : Person
    {
        public string name;
        public sealed override void display()
        {
            Console.WriteLine("Hello");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s= new Student();
            s.display();
            Console.ReadLine();
        }
    }
}
