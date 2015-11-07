using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_10001stPrime
{
    class Bertha
    {
        public void primeGenesis(int x)
        {
            int count = 1;
            long optimus = 0;
            long tempie = 1;
            //Provide numbers to be tested
            while (count <= x)
            {
                tempie++;
                //Test for prime
                if (isPrime(tempie))
                {
                    count++;
                    optimus = tempie;
                }
            }
            Console.Out.WriteLine("The " + x + "th prime number is: " + optimus);
        }

        public static Boolean isPrime(long x)
        {
            for (long i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
