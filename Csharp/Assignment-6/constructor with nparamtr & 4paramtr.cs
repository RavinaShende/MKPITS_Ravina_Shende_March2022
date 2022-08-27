using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class employee having fields empno,empname , designation
//and salary , create a constructor with no parameters and
//create another parameterized constructor with 4 parameters

namespace ass30
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;

        //1-create a constructor with no parameter
        public Employee()
        {
            empno = 101;
            empname = "Rakesh";
            designation = "Manager";
            salary = 25000;
        }
        //parameterized constructor with 4 parameters
        public Employee(int empno, string empname, string designation, int salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Employee no. :" + empno);
            Console.WriteLine("Employee name :" + empname);
            Console.WriteLine("Employee designation :" + designation);
            Console.WriteLine("Employee salary :" + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();//this will call constructor automatically
            emp.display();
            Console.WriteLine("-----------------employee details-----------------");
            Employee e1 = new Employee(35, "shirsha", "designer", 15000);//parameterized constructor
            e1.display();
            Console.WriteLine("-----------------employee details-----------------");
            Console.WriteLine("Employee no. :");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee name & designation :");
            string empname = Console.ReadLine();
            string designation = Console.ReadLine();
            Console.WriteLine("Employee salary :");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------employee details-----------------");
            Employee e2 = new Employee(empno, empname, designation,salary);
            e2.display();
            Console.ReadLine();
        }
       
    }
}
