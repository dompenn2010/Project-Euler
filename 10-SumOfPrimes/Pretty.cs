//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//Find the sum of all the primes below two million.
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_SumOfPrimes
{
    class Pretty
    {
        static ArrayList listOfPrimes = new ArrayList();

        public void primeGenesis(int x)
        {
            long tempie = 1;
            long sum = 0;

            //Provide numbers to be tested
            while (tempie < x)
            {
                tempie++;
                //Test for prime
                if (isPrime(tempie))
                {
                    sum += tempie;
                }
            }
            Console.Out.WriteLine("The sum of all prime numbers under " + x + " is: " + sum );
        }
        /*
        public static Boolean isPrime(long x)
        {
            for (int i = 1; i < listOfPrimes.Count; i++ )
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            Console.Out.WriteLine("Adding: " + x);
            listOfPrimes.Add(x);
            return true;
        }
        */
        
        public static Boolean isPrime(long x)
        {
            for (long i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            listOfPrimes.Add(x);
            return true;
        }
         
    }
}
