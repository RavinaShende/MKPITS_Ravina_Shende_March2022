using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg11_7_protected_access_modifier_
{
    public class Person
    {
        string name;
        string address;
        protected void getPersonData(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        protected void displayPersonData()
        {
            
            Console.WriteLine("name  " + name);
            Console.WriteLine("address "+address);
        }
    }
    public class Student : Person
    {
        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {
            getPersonData("Africa", "Nagpur");//call base class method from derived class
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            displayPersonData(); //calling base class method from derived class
            Console.WriteLine("rno :" + rno);
            Console.WriteLine("marks :" + marks);
        }
    }
    class Testinheritance
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();
            p1.getStudentData(111, 999);
            p1.displayStudentData();
            //p1.getPersonData("arifa", "nagpur"); //since testinhertance class in not derived class of person
            //p1.displayPersonData(); //since testinhertance class in not derived class of person
            Console.ReadLine();
        }
    }
}
