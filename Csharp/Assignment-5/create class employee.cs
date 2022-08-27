using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class employee having fields empno,empname ,designation , basicsalary
//and method calcuatesalary to display hra ie 32% of basicsalary, da ie 43%of basicsalary,
//ta ie 45% of basicsalary and totalsalary(ie hra+da+ta+basicsalary)

namespace ass27_create_class_employee_
{
    class Employee
    {
        public int empno;
        public string empname;
        public string designation;
        public float basicsal, hra, da, ta, total;

        public void getempdata()
        {
            Console.WriteLine("Enter Employee no :");
            empno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee name :");
            empname=Console.ReadLine();
            Console.WriteLine("Enter Designation :");
            designation=Console.ReadLine();
            Console.WriteLine("Enter basic salary:");
            basicsal=Convert.ToSingle(Console.ReadLine());
        }
        public void displayempdata()
        {
            hra = basicsal * 0.32f;
            Console.WriteLine("HRA = " + hra);
            da = basicsal * 0.43f;
            Console.WriteLine("DA = " + da);
            ta = basicsal * 0.45f;
            Console.WriteLine("TA = " + ta);
            total = basicsal + hra + da + ta;
            Console.WriteLine("Total salary = " + total);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getempdata();
            emp.displayempdata();
            Console.ReadLine();
        }
    }
}
