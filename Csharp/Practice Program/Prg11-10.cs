using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg11_10_multi_level_inheritance_
{
    public class Person
    {
        string name;
        string address;
        public void getPersonData(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address :" + address);
        }
    }
    public class Employee:Person
    {
        int salary;
        string designation;
        public void getEmployeeData(int salary,string designation)
        {
           // getPersonData("arifa", "nagpur");  //calling base class method from derived class
            this.salary = salary;
            this.designation = designation;
        }
        public void displayEmployeeData()
        {
            displayPersonData();  //calling base class method from derived class
            Console.WriteLine("salary :" + salary);
            Console.WriteLine("designation : " + designation);
        }
    }
    public class ParttimeEmployee : Employee
    {
        int no_of_hours;
        public void getParttimeEmployeeData(int no_of_hours)
        {
           // getPersonData("arifa", "nagpur"); //calling base class method from derived class
            this.no_of_hours = no_of_hours;
        }
        public void displayParttimeEmployeeData()
        {
           // displayPersonData(); //calling base class method from derived class
            displayEmployeeData();
            Console.WriteLine("no. of hours : " + no_of_hours);
        }

    }
    internal class TestInheritance
    {
        public static void Main(string[] args)
        {
            ParttimeEmployee p1 = new ParttimeEmployee(); //creating object of child class
            p1.getPersonData("africa","nagpur");
            p1.getEmployeeData(111, "manager");
            p1.getParttimeEmployeeData(5);

            p1.displayPersonData();
            Console.WriteLine("\t");
            p1.displayEmployeeData();
            Console.WriteLine("\t");
            p1.displayParttimeEmployeeData();
            Console.ReadLine();
        }
    }
}
