using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass14_1_prime1_20_
{
    internal class Prime
    {
        static void Main(string[] args)
        {
            //wap to print prime no from 1 to 20
           
            int num, i, ctr;
            
            for(num=1;num<=20;num++)
            {
                ctr = 0;
                for(i=2;i<=num/2;i++)
                {
                    if(num%i==0)
                    {
                        ctr++;
                        break;
                    }
                }
                if (ctr == 0 && num != 1)
                    Console.WriteLine("{0}", num);
            }
            Console.ReadLine();
        }
    }
}
