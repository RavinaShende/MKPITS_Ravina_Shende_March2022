using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass11_clerk_ifelse_
{
    internal class Office
    {
        static void Main(string[] args)
        {
            //wap to accept empno,empname,designation , calculate & display bonus ie 10000 for manager,
            //5000 for clerk & 2000 for peon (using if else)
           
            string empname, designation;
            int bonus = 0;
            Console.WriteLine("Enter employee no. :");
            int empno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employe Name & Designation");
            empname = Console.ReadLine();
            designation = Console.ReadLine();

            if (designation == "manager")
                bonus = 10000;
            else if (designation == "clerk")
                bonus = 5000;
            else
                bonus = 2000;

            Console.WriteLine("Employee no.:" + empno);
            Console.WriteLine("Employee name:" + empname);
            Console.WriteLine("Designation:" + designation);
            Console.WriteLine("Bonus = " + bonus);
            Console.ReadLine();
        }
    }
}
