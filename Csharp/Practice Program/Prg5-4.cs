using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg5_4_pass_data_
{
    class Employee
    {
        public int empno;
        public string empname;
        public double salary;

        // creating getdata() & showdata() methods
        public void getdata(int e1,string en,double sa)
        {
            empno = e1;
            empname = en;
            salary = sa;
        }
        public void showdata()
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
            Employee emp=new Employee();
            emp.getdata(11, "amit", 25464);
            emp.showdata();
            Console.ReadLine();
        }
    }
}
