using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg25_2
{
    internal class Bank
    {
        public int accountno;
        public int balance = 1000;
        public string deposit(int amount)
        {
            balance = balance + amount;
            return "Amount deposited successfully, balence is " + balance.ToString();
        }
        public string withdrawl(int amount)
        {
            string res = null;
            if(amount > balance )
            {
                res = "insufficient fund, cannot withdraw money";
            }
            else
            {
                balance = balance - amount;
                res = "amount withdrawl successfully, balance is" + balance.ToString();
            }
            return res;
        }
        public string showbalance()
        {
            return "balance amount is " + balance.ToString();
        }
    }
}
