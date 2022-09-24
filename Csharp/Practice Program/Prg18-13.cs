using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg18_13
{
    public class Account
    {
        public int accno;
        public string name;
        public static int count = 0;
        public Account (int accno, string name)
        {
            this.accno = accno;
            this.name = name;
            count++;
        }
        public void display()
        {
            Console.WriteLine(accno + " " + name);
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account(101, "Sonoo");
            Account a2 = new Account(102, "Mahesh");
            Account a3 = new Account(103, "Ajit");
            a1.display();
            a2.display();
            a3.display();
            Console.WriteLine("Total Objects are : " + Account.count);
            Console.ReadLine();
        }
    }
}
