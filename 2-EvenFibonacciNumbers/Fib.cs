//By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
//find the sum of the even-valued terms.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Fib
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int ceiling = 4000000;
            int previous = 0;
            int current = 1;

            //Until we reach four million
            while (current <= ceiling)
            {
                //If the number is even, add it to the sum
                if (current % 2 == 0)
                {
                    sum += current;
                }

                //Update the previous and current numbers.
                int temp = previous + current;
                previous = current;
                current = temp;
            }
            Console.Out.WriteLine("The sum of the even-valued terms not exceeding four million is: " + sum);
            Console.ReadKey();
        }
    }
}
