using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class student having fields rno,name,mathsmarks, chemmarks,phymarks,
//total, per,grade and method result to calculate and display total, per and grade

namespace ass26_create_class_student_
{
    class Student
    {
        public int rno;
        public string name;
        public int mathmarks;
        public int chemmarks;
        public int phymarks;
        public int total;
        public float per;

        public void getstudentdata()
        {
            Console.WriteLine("Enter student no. :");
            rno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student name :");
            name=Console.ReadLine();
            Console.WriteLine("Enter math, chem, phy subject marks :");
            mathmarks=Convert.ToInt32(Console.ReadLine());
            chemmarks=Convert.ToInt32(Console.ReadLine());
            phymarks=Convert.ToInt32(Console.ReadLine());
        }
        public void displaydata()
        {
            total = (mathmarks + chemmarks + phymarks);
            per = (total / 300.0f) * 100;
            Console.WriteLine("Total = " + total);
            Console.WriteLine("Percentage = " + per);
            if (per >= 75)
            {
                Console.WriteLine("Grade = Distinction");
            }
            else if (per >= 60 && per < 75)
            {
                Console.WriteLine("Grade = First Division");
            }
            else if (per >= 40 && per < 60)
            {
                Console.WriteLine("Grade = Second Division");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.getstudentdata();
            s1.displaydata();
            Console.ReadLine();
        }
    }
}
