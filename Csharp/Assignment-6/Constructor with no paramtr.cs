using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class employee having fields empno,empname,designation & salary
//create a constructor with no parameter with method display
namespace ass_constructor_nparamtr_
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        double salary;

        //creting constructor with no parameter
        public Employee()
        {
            empno = 4;
            empname = "shirsha";
            designation = "clerk";
            salary = 542454;
        }

        public void display()
        {
            Console.WriteLine("Employee no : " + empno);
            Console.WriteLine("Employee name : " + empname);
            Console.WriteLine("Employee designation : " + designation);
            Console.WriteLine("Employee salary : " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.display();
            Console.ReadLine();
        }
    }
}
