using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass9_emphra_da_
{
    internal class Calculate
    {
        static void Main(string[] args)
        {
            int empno, basic;
            Console.WriteLine("Enter Employee Number :");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Basic");
            basic = Convert.ToInt32(Console.ReadLine());
            float hra = 0;
            float da = 0;

            switch(basic)
            {
                case 25000:
                    hra = basic * 0.32f;
                    da = basic * 0.45f;
                    break;
                case 50000:
                    hra = basic * 0.32f;
                    da = basic * 0.45f;
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }
            float total = basic + hra + da;
            Console.WriteLine("Employee number = " + empno);
            Console.WriteLine("HRA = "+hra);
            Console.WriteLine("DA = " + da);
            Console.WriteLine("Total Salary = " + total);
            Console.ReadLine();
        }
    }
}
