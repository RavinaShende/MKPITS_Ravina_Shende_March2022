using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ass15_student_total_per__grade_
{
    internal class Program
    {
        //create a method to
        //accept 3 subject marks and print total,per and grade
        static void display(int n1, int n2, int n3)
        {
            int total = n1 + n2 + n3;
            float per = (total / 300.0f) * 100;
            Console.WriteLine("\nTotal = " + total);
            Console.WriteLine("\nPercentage = " + per);
            if(per >= 75)
            {
                Console.WriteLine("Grade = Distinction");
            }
            else if(per >= 60 && per <75)
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
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Enter subject 1 marks:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter subject 2 marks:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter subject 3 marks:");
            n3 = Convert.ToInt32(Console.ReadLine());
            display(n1, n2, n3);
            Console.ReadLine();
        }
    }
}
