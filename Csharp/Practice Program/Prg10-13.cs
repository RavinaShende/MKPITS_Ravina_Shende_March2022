using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_13
{
    class Student
    {
        private int rno;
        public void getdata(int rno)
        {
            this.rno = rno;
        }
        public void displaydata()
        {
            Console.WriteLine("rno " + rno);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            //s.rno = 1; error
            s.getdata(11);
            s.displaydata();
            Console.ReadLine();
        }
    }
}
