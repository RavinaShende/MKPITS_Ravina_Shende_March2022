using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// example of runtime polymorphism (method overriding)
//create a base class account having fields actno, bal and methods deposit  and showbalance
//create a derieved class current inherited from account class and override the deposit method
//create another derieved class saving inherited from account class and override the deposit method (add interest with amount)

namespace Prg16_12
{
    class Account
    {
        public int actno;
        public int balance = 1000;
       
        public virtual String deposit(int actno,int amount)
        {
            return "deposit method of accoun class";
        }
        public String showbalance()
        {
            return "balance amount : " + balance;
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
    class Saving:Account
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
    internal class TestBase
    {
        public static void Main(string[] args)
        {
            //runtime polymorphism : base class reference variable having
            //instance of derieved class current
            Console.WriteLine("Enter acount no");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited");
            int amount = Convert.ToInt32(Console.ReadLine());

            Account act = new Current();
            String res = act.deposit(actno, amount);
            Console.WriteLine("account no is " + act.actno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);

            //instance of derieved class saving
            Console.WriteLine("Enter acount no");
            int actno1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to be deposited");
            int amount1 = Convert.ToInt32(Console.ReadLine());

            Account sav = new Saving();
            string res1 = sav.deposit(actno, amount);
            Console.WriteLine("account no is " + sav.actno);
            Console.WriteLine(res1);
            res1 = sav.showbalance();
            Console.WriteLine(res1);
            Console.ReadLine();
        }
    }
}
