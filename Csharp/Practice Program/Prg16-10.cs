﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg16_10
{
    class Account
    {
        public int actno;
        public int balence = 1000;
        public virtual String deposit(int actno, int amount)
        {
            return "deposit method of account class";
        }
        public String showbalance()
        {
            return "balance amount : " + balence;
        }
    }
    class Current : Account
    {
        //overriding the base class deposit method 
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balence = balence + amount;
            return "amount deposited successfully in current class";
        }
    }
    internal class TestBase
    {
        public static void Main(string[] args)
        {
            //runtime polymorphism : base class reference variable
            //having instance of derieved class current
            Account act = new Current();
            String res = act.deposit(123, 2000);
            Console.WriteLine("account no is " + act.actno);
            Console.WriteLine(res);
            res=act.showbalance();
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
