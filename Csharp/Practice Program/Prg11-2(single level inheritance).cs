using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// create a base class having fields salary, then create a derived class programmer having additional field bonus
namespace Prg11_2_single_level_inheritance_
{
    //create a base class employee
    class Employee
    {
        public float salary = 40000;
    }
    //create derived class
    class Programmer : Employee
    {
        public float bonus = 10000;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer p1 = new Programmer();
            Console.WriteLine("Salary : " + p1.salary);
            Console.WriteLine("Bonus : "+p1.bonus);
            Console.ReadLine();
        }
    }
}
