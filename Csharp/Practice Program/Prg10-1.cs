using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_1_access_modifier_or_specifier_
{
    class Student
    {
        internal int rno;
        internal string name;
        public void displaydata()
        {
            Console.WriteLine("Roll no." + rno);
            Console.WriteLine("Name " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(); //this will call constructor automatically
            s.rno = 2;
            s.name = "ravi";
            s.displaydata();
            Console.ReadLine();
        }
    }
}
