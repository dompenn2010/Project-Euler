using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Maths
    {

        public void diffOfSumofSquare(int x)
        {
            long i = squareOfSum(x);
            long j = sumOfSquares(x);
            long k = (i - j);

            Console.Out.WriteLine("The difference between the square of the sum of the first " + x
                + " \nnumbers and the sum of the squares of the first " + x + " numbers is: " + k);
        }

        public long squareOfSum(int x)
        {
            long iCalc;
            long temp = 0;

            for (int i = 1; i <= x; i++)
            {
                temp += i;
            }

            iCalc = (temp * temp);

            return iCalc;

        }

        public long sumOfSquares(int x)
        {
            long jCalc;
            long temp = 0;

            for (int i = 1; i <= x; i++)
            {
                temp += (i*i);
            }

            jCalc = temp;

            return jCalc;
        }
 
    }
}
