using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg11_9_protected_internal_access_modifier_
{
    class Person
    {
        string name;
        protected void  getPersonData(string name)
        {
            this.name = name;
            Console.WriteLine("name = " + name);
        }
    }
    class Employee : Person
    {
        int empno;
        internal void getEmployeeData(int empno, string name)
        {
            this.empno = empno;
            Console.WriteLine("empno = " + empno);
            getPersonData(name); // calling base class
        }
            
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getEmployeeData(11, "shreyash");
            Console.ReadLine();
        }
    }
}
