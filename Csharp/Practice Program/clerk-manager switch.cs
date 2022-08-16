using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg2_5
{
    internal class Office
    {
        static void Main(string[] args)
        {
            string empname, designation;
            int bonus = 0;
            Console.WriteLine("Enter Employe Name & Designation");
            empname = Console.ReadLine();
            designation = Console.ReadLine();

            switch (designation)
            {
                case "Manager":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;
                default:
                    Console.WriteLine("Invalid designation");
                    break;
            }
            Console.WriteLine("Employe Name = {0} , Bonus = {1}", empname, bonus);
            Console.ReadLine();
        }
    }
}
