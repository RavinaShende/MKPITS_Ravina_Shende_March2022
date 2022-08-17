using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    //create a class employee having methods getdata & showdata
namespace Prg5_3_getdata_showdata_
{
    class Employee
    {
        int empno;
        string empname;
        float salary;

        //creating methods
        public void getdata()
        {
            Console.WriteLine("enter employee no");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name");
            empname = Console.ReadLine();
            Console.WriteLine("enter employee salary");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void displaydata()
        {
            Console.WriteLine("empno" + empno);
            Console.WriteLine("empname" + empname);
            Console.WriteLine("salary" + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getdata();
            emp.displaydata();
            Console.ReadLine();

        }
    }
}
