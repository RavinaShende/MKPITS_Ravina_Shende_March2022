﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_18_method_of_returning_of_array_
{
    internal class Program
    {
        static int[] returnarray ()
        {
            int[] num = { 1, 2, 3 };
            return num;
        }
        static void Main(string[] args)
        {
            int[] arr=returnarray ();
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
