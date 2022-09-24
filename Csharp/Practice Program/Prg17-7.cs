using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_7_encapsulation_
{
    class Employee
    {
        //string empname;
        public string empname { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empname = "ravi"; //this will call setter
            Console.WriteLine("Employee name : " + emp.empname);//this will call getter
            Console.ReadLine();
        }
    }
}
