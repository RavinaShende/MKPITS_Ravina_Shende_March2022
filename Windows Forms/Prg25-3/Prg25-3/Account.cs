using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg25_3
{
     abstract class Account
    {
        public int accountno;
        public int balance = 1000;
        public abstract string deposit(int amount);
        public string withdrawl (int amount)
        {
            string res = null;
            if(amount>balance)
            {
                res = "insufficient fund, cannot withdraw money";
            }
            else
            {
                balance = balance - amount;
                res = "amount withdrawl successfully, bal is " + balance.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "balance amount is " + balance.ToString();
        }
    }
    class Saving : Account
    {
        public override string deposit(int amount)
        {
            int interest = 500;
            balance = balance + amount + interest;
            return "amount deposited successfully with interest,bal is " + balance.ToString();
        }
    }
    class Current:Account
    {
        public override string deposit (int amount)
        {
            balance = balance + amount;
            return "amount deposited successfully without interest, bal is " + balance.ToString();
        }
    }
}
