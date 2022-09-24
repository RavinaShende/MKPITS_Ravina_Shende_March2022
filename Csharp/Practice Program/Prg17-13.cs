using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_13
{
    interface bank
    {
        string deposit(int actno, int amt);
    }
    class Account
    {
        public int actno;
        public int bal = 1000;
    }
    class Saving : Account, bank
    {
        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposited successfully, bal is " + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           bank b;
            b = new Saving();
            String str = b.deposit(1, 400);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
