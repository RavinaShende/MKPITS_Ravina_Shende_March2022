using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg17_8_access_specifier_
{
    class Student
    {
        //creating setter & getter for each property
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            //setting values to the property
            s.ID = "101";
            s.Name = "Mohan Ram";
            s.Email = "mohan@gmail.com";

            // getting values
            Console.WriteLine("ID = " + s.ID);
            Console.WriteLine("Name = " + s.Name);
            Console.WriteLine("Email = " +s.Email);
            Console.ReadLine();
        }
    }
}
