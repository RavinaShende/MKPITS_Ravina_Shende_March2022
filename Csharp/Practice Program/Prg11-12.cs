using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a base class person having fields name and address
//create a deireved class student inherited from person class having fields rno and marks
//create another derieved class employee inherited from person class having fields salary and designation

namespace Prg11_12_hierarchical_inheritance_
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
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);
        }
    }
    public class Student : Person
    {
        int rno;
        int marks;
        public void getStudentData(int rno,int marks)
        {
            Console.WriteLine("\t");
            //getPersonData("arifa", "nagpur");//calling base class method from derieved class
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            //displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("rno : " + rno);
            Console.WriteLine("marks : " + marks);
        }
    }
    public class Employee : Person
    {
        int salary;
        string designation;
        public void getEmployeeData(int salary,string designation)
        {
           // getPersonData("arifa", "nagpur"); //calling base class method from derieved class
            this.salary = salary;
            this.designation = designation;
        }
        public void displayEmployeeData()
        {
            //displayPersonData(); //calling base class method from derieved class
            Console.WriteLine("salary : " + salary);
            Console.WriteLine("designation : " + designation);
        }
    }
    internal class TestInheritance
    {
        public static void Main(string[] args)
        {
            //creating object of student class
            Student p1 = new Student();
            p1.getPersonData("payal", "nagpur");
            p1.getStudentData(111, 999);
            p1.displayPersonData();
            p1.displayStudentData();
            Console.WriteLine("\t");
            //creating object of student class
            Employee p2 = new Employee();
            p2.getPersonData("monish", "wardha");
            p2.getEmployeeData(9999, "manager");
            p2.displayPersonData();
            p2.displayEmployeeData();

            Console.ReadLine();
        }
    }
}
