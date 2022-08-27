using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prg4_13_array_sort_method_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num ={ 1,9,5,7,2,3 };
            Array.Sort(num);
            //display array elements
            for(int i=0;i<num.Length;i++)
            {
                Console.Write(num[i] + "\t");
            }
            Console.ReadLine();
        }
    }
}
