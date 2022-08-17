using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg5_1
{
    // Create a class employee having fields empno, empname & salary
    internal class Employee
    {
        int empno;
        string empname;
        float salary;
        static void Main(string[] args)
        {
            //creating an object (instance) of employee class
            //syntax classname objectname = new classname();
            Employee emp = new Employee();

            emp.empno = 123;
            emp.empname = "mohit";
            emp.salary = 12546.45f;

            Console.WriteLine("empno " + emp.empno);
            Console.WriteLine("empname " + emp.empname);
            Console.WriteLine("Salary " + emp.salary);
            Console.ReadLine();

        }
    }
}
