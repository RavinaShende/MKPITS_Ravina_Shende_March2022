using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass33_runtime_polymorphism__on_acc.withdraw_
{
    internal class Account
    {
        public int actno;
        public int balance = 1000;
        public virtual string withdraw(int actno, int amount)
        {
            return "withdraw method of account class";
        }
        public string showbalance()
        {
            return " balance amount : " + balance;
        }
    }
    class Current : Account
    {
        //overriding the base class withdraw method
        public override string withdraw(int actno, int amount)
        {
            this.actno = actno;
            balance = balance - amount;
            return " amount withdraw successfully without interest in current class";
        }
    }
    class Saving : Account
    {
        //overriding the base class withdraw method
        public override string withdraw(int actno, int amount)
        {
            this.actno = actno;
            int interest = 500;
            balance = balance + interest - amount;
            return "amount withdraw successfully with interest in saving class";
        }
    }
    public class TestBase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account no :");
            int actno = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter amount to be withdraw :");
             int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter account type (saving or current)");
            String acttype = Console.ReadLine();

            Account act = null;
            if (acttype == "saving")
            {
                act = new Saving();
            }
            else if (acttype == "current")
            {
                act = new Current();
            }
            
            String res = act.withdraw(actno, amount);
            Console.WriteLine("account no. is " + act.actno);
            
            Console.WriteLine(res);

            res = act.showbalance();
            
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
