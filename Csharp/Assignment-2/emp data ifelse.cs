﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass9_1_emphra_da_ifelse_
{
    internal class Calculate
    {
        static void Main(string[] args)
        {
            //wap to accept empno,empname,basicsalary and calculate hra ie 32 % of basic, da ie 45 % of basic
            //& display empno,empname , hra , da , total salary
            int empno,basic;
            Console.WriteLine("Enter Employee Number :");
            empno = Convert.ToInt32(Console.ReadLine());
            string empname;
            Console.WriteLine("Enter Employee Name :");
            empname = Console.ReadLine();
            Console.WriteLine("Enter Basic");
            basic = Convert.ToInt32(Console.ReadLine());
            float hra = 0;
            float da = 0;

            if (basic >= 10000 && basic <= 25000)
            {
                hra = basic * 0.32f;
                da = basic * 0.45f;
            }
            else if(basic >= 25000 && basic <= 50000)
            {
                hra = basic * 0.32f;
                da = basic * 0.45f;
            }
            else if (basic == 10000)
            {
                hra = 0;
                da = 0;
            }
            float total = basic + hra + da;
            Console.WriteLine("Employee no. :" + empno);
            Console.WriteLine("Employee Name :" + empname);
            Console.WriteLine("HRA = " + hra);
            Console.WriteLine("DA = " + da);
            Console.WriteLine("Total Salary = " + total);
            Console.ReadLine();

        }
    }
}
