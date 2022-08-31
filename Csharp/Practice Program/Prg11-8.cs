using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg11_8_protected_internal_access_modifier_
{
    public class Person
    {
        string name;
        string address;
        protected internal void getPersonData(string name,  string address)
        {
            this.name = name;
            this.address = address;
        }
        protected internal void displayPersonData()
        {
            Console.WriteLine("name  = " + name);
            Console.WriteLine("address  = " + address);
        }
    }
    public class Student : Person
    {
        int rno;
        int marks;
        public void getStudentData(int rno,int marks)
        {
           
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            displayPersonData();
            Console.WriteLine("rno = " + rno);
            Console.WriteLine("marks = " + marks);
        }
    }
    internal class TestInheritance
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.getPersonData("samiksha", "nagpur");
            s.getStudentData(111, 699);
            s.displayStudentData();
           // s.displayPersonData();
            Console.ReadLine();
        }
    }
}
