using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_12
{
    interface bank
    {
        string deposit(int actno, int amt);
    }
    class Saving : bank
    {
        int actno;
        int bal = 1000;
        public string deposit (int actno, int amt)
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
            String str = b.deposit(1, 200);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
