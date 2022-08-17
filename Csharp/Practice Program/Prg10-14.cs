using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_14
{
    class Student
    {
        int rno;
        string name;

        public Student()
        {
            rno = 11;
            name = "amitabh";
        }
        public Student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
        public void displaydata()
        {
            Console.WriteLine("rno " + rno);
            Console.WriteLine("name " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.displaydata();
            Student s1 = new Student(111,"rajesh");
            s1.displaydata();
            Console.ReadLine();
        }
    }
}
