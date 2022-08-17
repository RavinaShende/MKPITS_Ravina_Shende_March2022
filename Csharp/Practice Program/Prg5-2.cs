using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg5_2_create_class_
{
    //create a class employee having fields empno, empname & salary
    class Employee
    {
        public int empno;
        public string empname;
        public float salary;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating an object (instance) of employee class
            // syntax : classname objectname = new classname();
            Employee emp = new Employee();

            Console.WriteLine("Enter Employee No");
            emp.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emter Employee Name");
            emp.empname = Console.ReadLine();
            Console.WriteLine("Enter Employee salary");
            emp.salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("empno" + emp.empno);
            Console.WriteLine("empname " + emp.empname);
            Console.WriteLine("empsalary"+emp.salary);
            Console.ReadLine();

        }
    }
}
