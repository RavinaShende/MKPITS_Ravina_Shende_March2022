using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg18_5_sealed_
{
    abstract class Person
    {
        public string name;
    }
    class Student : Person
    {
        public int rno;
    }
    sealed class Parttimestudent : Student
    {
        public int hours;
    }

    internal class TestSealed
    {

        static void Main(string[] args)
        {
            Parttimestudent p = new Parttimestudent();
            p.rno = 22;
            p.name = "ratan";
            p.hours = 5;

            Console.WriteLine("Roll no : " + p.rno);
            Console.WriteLine("Name : " + p.name);
            Console.WriteLine("Time : " + p.hours);
            Console.ReadLine();
        }
    }
}
