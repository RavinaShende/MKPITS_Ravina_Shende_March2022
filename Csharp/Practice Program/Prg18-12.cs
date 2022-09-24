using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg18_12
{
    public class Account
    {
        public int accno;
        public string name;
        public static float rateOfInterest = 8.8f;
        public Account(int accno, String name)
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
            Account.rateOfInterest = 10.5f; //Changing value
            Account a1 = new Account(101, "Sonoo");
            Account a2 = new Account(102, "Mahesh");
            a1.display();
            a2.display();
            Console.ReadLine();
        }
    }
}
