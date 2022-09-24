﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg16_13
{
    internal class Account
    {
        public int actno;
        public int balance = 1000;
        public virtual string deposit(int actno, int amount)
        {
            return "deposit method of account class";
        }
        public string showbalance()
        {
            return " balance amount : " + balance;
        }
    }
    class Current : Account
    {
        //overriding the base class deposit method
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return " amount deposited successfully without interest in current class";
        }
    }
    class Saving : Account
    {
        //overriding the base class deposit method
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            int interest = 500;
            balance = balance + amount + interest;
            return "amount deposited successfully with interest in saving class";
        }
    }
    public class TestBase
    { 
    static void Main(string[] args)
        {
            //runtime polymorphism : base class reference variable
            //having instance of derived class current

            Console.WriteLine("Enter account no :");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited :");
            int amount=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type (saving or current)");
            String acttype = Console.ReadLine();

            Account act = null;
            if(acttype == "saving")
            {
                act=new Saving();
            }
            else if(acttype == "current")
            {
                act=new Current();
            }
            String res = act.deposit(actno, amount);
            Console.WriteLine("account no. is " + act.actno);
            Console.WriteLine(res);
            res=act.showbalance();
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
