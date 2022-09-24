using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg18_11
{
    public class Account
    {
        public int accno;
        public string name;
        public static float rateOfInterest = 8.8f;
        public Account (int accno, String name)
        {
            this.accno = accno;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(accno + " " + name + " " + rateOfInterest);
        }
    }
    internal class TestAccount
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account(101, "Soono");
            Account a2 = new Account(102, "Mahesh");
            a1.display();
            a2.display();
            Console.ReadLine();
        }
    }
}
