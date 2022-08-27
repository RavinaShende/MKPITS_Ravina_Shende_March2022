using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg10_3_public_access_specifier_
{
    class PublicTest
    {
        public string name = "santosh kumar";
        public void Msg(string msg)
        {
            Console.WriteLine("Hi "+msg);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            PublicTest publicTest = new PublicTest();//Accessing public variable
            Console.WriteLine("Hello "+publicTest.name);//Accessing public function
            publicTest.Msg("Peter Decosta");
            Console.ReadLine();
        }
    }
}
