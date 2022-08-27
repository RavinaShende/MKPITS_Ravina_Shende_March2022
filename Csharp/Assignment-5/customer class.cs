using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass20_create_class_for_cust._
{
    //create a class customer having fields
    //custno,custname,custaddress,custtelno
    class customer
    {
        public int custno;
        public string custname;
        public string custaddress;
        public long custtelno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            cust.custno = 123;
            cust.custname = "Ravina";
            cust.custaddress = "chandrapur";
            cust.custtelno = 5454444876;

            Console.WriteLine("Custno :" + cust.custno);
            Console.WriteLine("Custname :"+cust.custname);
            Console.WriteLine("custaddress :" + cust.custaddress);
            Console.WriteLine("custtelno :" + cust.custtelno);
            Console.ReadLine();
        }
    }
}
