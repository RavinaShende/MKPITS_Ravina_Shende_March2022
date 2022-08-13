using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//create a class car having fields make,model
//and method getcardata and displaycardata
namespace ass23_create_class_for_car_
{
    class Cardata
    {
        int carno;
        string carmake;
        string carmodel;
        float carprice;
        
        public void getcardata()
        {
            Console.WriteLine("Enter car no. :");
            carno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter car make :");
            carmake=Console.ReadLine();
            Console.WriteLine("Enter car model :");
            carmodel=Console.ReadLine();
            Console.WriteLine("Enter car price :");
            carprice=Convert.ToInt32(Console.ReadLine());
        }
        public void displaycardata()
        {
            Console.WriteLine("Car no. :"+carno);
            Console.WriteLine("Car make :" + carmake);
            Console.WriteLine("Car model no. :" + carmodel);
            Console.WriteLine("Car Price :" + carprice);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cardata c = new Cardata();
            c.getcardata();
            c.displaycardata();
            Console.ReadLine();
        }
    }
}
