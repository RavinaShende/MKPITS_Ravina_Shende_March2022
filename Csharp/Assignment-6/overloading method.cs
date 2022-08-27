using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class student having fields rno,name,course,fees
//create a method getdata with no parameters , create overloaded method
//with 2 parameters, 3 parameters, 4 parameters and display method
namespace ass32_method_overloading_
{ 
    class Student
    {
        int rno;
        string name, course;
        int fees;

        public void getdata()
        {
            rno = 11;
            name = "Ravina";
            course = "VB.net";
            fees = 10000;
        }
        //method overloaded
        public void getdata(int rno)
        {
            this.rno = rno;
        }
        public void getdata(int rno,string name)
        {
            this.rno = rno;
            this.name = name;
        }
        public void getdata(int rno,string name,string course)
        {
            this.rno = rno;
            this.name=name;
            this.course = course;
        }
        public void getdata(int rno, string name, string course,int fees)
        {
            this.rno = rno;
            this.name = name;
            this.course = course;
            this.fees = fees;
        }
        public void display()
        {
            Console.WriteLine("Roll no. :" + rno);
            Console.WriteLine("Name " + name);
            Console.WriteLine("Course " + course);
            Console.WriteLine("fees = " + fees);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------student details--------------------");
            Student s = new Student();
            s.getdata();
            s.display();
            Console.WriteLine("---------------student details--------------------");
            Student s1 = new Student();
            s1.getdata(11, "payal");
            s1.display();
            Console.WriteLine("--------------student details--------------------");
            Student s2 = new Student();
            s2.getdata(11, "payal", "dotnet");
            s2.display();
            Console.WriteLine("---------------student details--------------------");
            Student s3 = new Student();
            s3.getdata(11, "payal", "dotnet", 2000);
            s3.display();
            Console.ReadLine();

        }
    }
}
