using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg5_6_same_classmembr_
{

    //method parameter having same classmembers name use this keyword to refer class member
    class Employee
    {
        int empno;
        string empname;
        float salary;
        //creating method
        public void getdata(int empno, string empname, float salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
        }
        public void displaydata()
        {
            Console.WriteLine("empno" + empno);
            Console.WriteLine("empname" + empname);
            Console.WriteLine("salary"+salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.WriteLine("enter employee no");
            int eno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            string en = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            float sal = Convert.ToSingle(Console.ReadLine());

            emp.getdata(eno, en, sal);
            emp.displaydata();
            Console.ReadLine();
        }
    }
}
