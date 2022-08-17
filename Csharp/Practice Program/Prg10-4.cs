using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_4_protected_access_specifier_
{
    class Student
    {
        protected string name;
        public void getdata()
        {
            name = "Ravi";
            Console.WriteLine("Name "+name);
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
