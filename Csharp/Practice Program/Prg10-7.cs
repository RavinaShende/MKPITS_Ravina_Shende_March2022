using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_7
{
    class ProtectedTest
    {
        protected string name = "shrikant";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hi " + msg);
        }
    }
    internal class Program : ProtectedTest
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //accessing protected variable
            Console.WriteLine("Hello " + p.name);//error corrected
            //accessing protected function
            p.Msg("Swami Ayyer");//error corrected
            Console.ReadLine();
        }
    }
}
