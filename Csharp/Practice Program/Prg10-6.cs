using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_6
{
    class ProtectedTest
    {
        protected string name = "shrikant";
        protected void Msg(string msg)
        {
            Console.WriteLine("Hi "+msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ProtectedTest p = new ProtectedTest();
            //accessing protected variable
            Console.WriteLine("Hello " + p.name);//error
            //accessing protected function
            protectedTest.Msg("Swami Ayyer");//error
           Console.ReadLine();
        }
    }
}
