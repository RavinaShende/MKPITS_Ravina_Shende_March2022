using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_4
{
    abstract class Person
    {
        //abstract method
        public abstract void display();
        //non abstract method
        public void showdata()
        {
            Console.WriteLine("Hello from showdata");
        }
    }
    class Student : Person
    {
        //implementation of abstract method display in derived class
        public override void display()
        {
            Console.WriteLine("Hello from display method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person(); error since person is abstract class
            Student s = new Student();
            s.display();
            s.showdata();
            Console.ReadLine();
        }
    }
}
