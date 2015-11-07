using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_PythagoreanTriplet
{
    class Magic
    {
        int target = 1000;

        public void tripletFinder()
        {
            double[] tripletFinal = new double[3];
            double[] tempGuess = new double[3];
            
            for (double i = 1; i < target; i++)
            {

                for (double j = i+1; j < target; j++ )
                {

                    double testie = Math.Pow(i, 2) + Math.Pow(j, 2);

                    if (Math.Sqrt(testie) % 1 == 0)
                    {
                        tempGuess[0] = i;
                        tempGuess[1] = j;
                        tempGuess[2] = Math.Sqrt(testie);
                    }

                    if (isEqualToTarget(tempGuess))
                    {
                        tripletFinal[0] = tempGuess[0];
                        tripletFinal[1] = tempGuess[1];
                        tripletFinal[2] = tempGuess[2];
                        break;
                    }
                }
            }

            Console.Out.WriteLine("The pythagorean triplet for which a + b + c = 1000 is: " + tripletFinal[0] + " " 
                + tripletFinal[1] + " " + tripletFinal[2] + "\nThe product is " + (tripletFinal[0]*tripletFinal[1]*tripletFinal[2]));

        }

        
        public Boolean isEqualToTarget(double[] tempGuess)
        {
            if ((tempGuess[0] + tempGuess[1] + tempGuess[2]) == target)
            {
                return true;
            }

            return false;
        }

    }
}
