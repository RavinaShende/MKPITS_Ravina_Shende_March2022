﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg3_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 3;
            while(true)
            {
                Console.WriteLine(i);
                i++;
                if (i <= 10)
                    continue;
                else
                    break;
            }
           // Console.WriteLine("bye");
            Console.ReadLine();
        }
    }
}
