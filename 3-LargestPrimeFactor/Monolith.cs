//What is the largest prime factor of the number 600851475143 ?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Monolith
    {
        static long target = 600851475143;
        static long largestSoFar;

        public static void Main(string[] args)
        {
            //We only need to test to the floor of the square root of the original number
            double newTarget = Math.Floor(Math.Sqrt((double)target));

            //Provide numbers to be tested
            for (long i = 2; i <= newTarget; i++)
            {
                //Test for prime
                if (isPrime(i))
                {
                    //Test for factor
                    if (target % i == 0)
                    {
                            //It's the largest prime factor so far
                            largestSoFar = i;

                            //If it is the largest prime factor then dividing the number by it will result in 1
                            if (target / largestSoFar == 1)
                            {
                                return largestSoFar;
                            }
                            else
                            {
                                target = target / largestSoFar;
                            }
                        
                    }
                }
            }
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
