using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_1_abstract_class_
{
    abstract class Account
    {
        public abstract void deposit();
    }
    class Saving : Account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello from saving deposit method");
        }
    }
    class Program
    { 
        static void Main(string[] args)
        {
             //Account act = new Account(); error
            Account act = new Saving();
            act.deposit();
            Console.ReadLine();
        }
    }
}
