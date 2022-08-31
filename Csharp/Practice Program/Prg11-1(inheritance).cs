using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg11_1_inheritance_
{
    //creating a base class
    class Person
    {
       public string name;
    }
    //creating a derived class student
    class Student : Person
    {
        public int rno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.rno = 111;
            s.name = "Rajesh";
            Console.WriteLine("Roll no :" + s.rno);
            Console.WriteLine("Name : " + s.name);
            Console.ReadLine();
        }
    }
}
