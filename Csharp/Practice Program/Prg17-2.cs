using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_2
{
    abstract class Account
    {
        public abstract void deposit(); // abstract method
        //non abstract method
        public void showbalance()
        {
            Console.WriteLine("Balance method");
        }
    }
    class Saving : Account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello from saving deposit method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //account act=new account(); error
            Account act = new Saving();
            act.deposit();
            act.showbalance();
            Console.ReadLine();
        }
    }
}
