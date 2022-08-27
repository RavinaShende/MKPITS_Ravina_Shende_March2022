using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class calculate having fields num1,num2 and 4 methods
//addition,substraction,multiplication and division

namespace ass24_create_class_calculate_
{
    class Calculate
     {
        public int num1;
        public int num2;
        public int resadd = 0;
        public int ressub = 0;
        public int resmul = 0;
        public int resdiv = 0;
        
        public void additiondata()
        {
            resadd = num1 + num2;
            Console.WriteLine("Addition = " + resadd);
        }
        public void substractiondata()
        {
            ressub = num1 - num2;
            Console.WriteLine("Substraction = " + ressub);
        }
        public void multiplicationdata()
        {
            resmul = num1 * num2;
            Console.WriteLine("Multiplication = " + resmul);
        }
        public void divisiondata()
        {
            resdiv = num1 / num2;
            Console.WriteLine("Division = " + resdiv);
        }
     }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            Console.WriteLine("Enter num1 & num2 ");
             calc.num1 = Convert.ToInt16(Console.ReadLine());
             calc.num2 = Convert.ToInt16(Console.ReadLine());

            calc.additiondata();
            calc.substractiondata();
            calc.multiplicationdata();
            calc.divisiondata();
            Console.ReadLine();
        }
    }
    
}
