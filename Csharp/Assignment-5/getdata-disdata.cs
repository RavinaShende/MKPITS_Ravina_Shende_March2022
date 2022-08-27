using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class customer having fields custno,custname,custaddress,custtelno
//and methods getcustomerdata and displaycustomerdata
namespace ass21_getdata_displaydata_
{
    class customer
    {
        int custno;
        string custname;
        string custaddress;
        int custtelno;

        public void getcustomerdada()
        {
            Console.WriteLine("Enter customer no. :");
            custno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter customer name :");
            custname=Console.ReadLine();
            Console.WriteLine("Enter customer address :");
            custaddress=Console.ReadLine();
            Console.WriteLine("Enter customer tel no. :");
            custtelno=Convert.ToInt32(Console.ReadLine());
        }

        public void displaycustomerdata()
        {
            Console.WriteLine("Customer no. :" + custno);
            Console.WriteLine("Customer name :" + custname);
            Console.WriteLine("Customer address :"+ custaddress);
            Console.WriteLine("Customer tel no. :" + custtelno);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer cust = new customer();
            cust.getcustomerdada();
            cust.displaycustomerdata();
            Console.ReadLine();
        }
    }
}
