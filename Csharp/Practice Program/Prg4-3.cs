﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_3_passbyreference_
{
    internal class Program
    {
        static void display(ref int num)
        {
            num++;
            Console.WriteLine("num inside method " + num);//6
        }
        static void Main(string[] args)
        {
            int num = 5;
            display(ref num);
            Console.WriteLine("num inside main " + num);//6
            Console.ReadLine();
        }
    }
    
}
