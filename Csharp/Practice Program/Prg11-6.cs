using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg11_6
{
    public class Person
    {
        string name;
        string address;
        public void getPersonData(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name :" + name);
            Console.WriteLine("address :"+address);
        }
    }
    public  class Student : Person
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
            Console.WriteLine("R no: " + rno);
            Console.WriteLine("marks :" + marks);
        }
    }
    class TestInheritance
    {
       public static void Main(string[] args)
        {
            Student p1 = new Student();
            p1.getPersonData("africa", "nagpur");
            p1.getStudentData(111, 999);
            p1.displayStudentData();
            p1.displayPersonData();
            Console.ReadLine();
        }
    }
}
