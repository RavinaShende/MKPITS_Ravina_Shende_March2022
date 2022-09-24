using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_14
{
    interface bank
    {
        string deposit(int actno, int amt);
        string withdraw(int actno, int amt);
    }
    class Account
    {
        public int actno;
        public int bal = 1000;
        public string showbalance()
        {
            return "balance is " + bal;
        }
    }
    class Saving : Account, bank
    {
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposited successfully, bal is " + bal;
        }
        public string withdraw(int actno,int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            return "withdraw successfully, bal is " + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Saving b;
            b = new Saving();
            string str = b.deposit(1, 300);
            Console.WriteLine(str);

            str = b.withdraw(1, 500);
            Console.WriteLine(str);
            Console.WriteLine(b.showbalance());
            Console.ReadLine();
        }
    }
}
