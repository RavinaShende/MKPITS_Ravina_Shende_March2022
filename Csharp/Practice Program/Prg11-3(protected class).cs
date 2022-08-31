using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg11_3_protected_class_
{
    //create base class Employee
    class Employee
    {
        protected int salary;
    }
    // create derived class Programmer
    class Programmer : Employee
    {
        public int bonus;
        public void getdata(int salary,int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("Salary " + salary);
            Console.WriteLine("Bonus " + bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            p.getdata(23000, 5000);
            p.displaydata();
            Console.ReadLine();
        }
    }
}
