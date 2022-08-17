using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_5
{
    class Person
    {
        protected string name;
    }
    //creating a child class student inherited from person class
    class Student : Person
    {
        public void getdata()
        {
            name = "Ravi";
            Console.WriteLine("name "+name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.getdata();
            Console.ReadLine();
        }
    }
}
