using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class PrimeNum
    {
        public static void CheckPrime(int n)
        {
            int i,m = 0,flag=0;
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    Console.Read();
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.Write("Number is Prime.");
                Console.Read();
            }
        }
    }
}
