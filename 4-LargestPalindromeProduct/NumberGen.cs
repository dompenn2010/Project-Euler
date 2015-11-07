//Find the largest palindrome made from the product of two 3-digit numbers.
//This class generates 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class NumberGen
    {
        //Array to hold our values
        private int[] largest = new int[3];

        public int generator()
        {
            //All three digit integers, decrementing...
            for (int i = 999; i >= 100; i--)
            {
                //... multiplied by all other three digit integers
                for (int j = i; j >= 100; j--)
                {
                    int george = j * i;

                    //If we find a palindrome...
                    if (Tester.pally.isPalindrome(Tester.pally.reverse(george)))
                    {
                        //... store it as the largest possible 
                        //because we are starting with the largest possible values
                        if (george > largest[0])
                        {
                            largest[0] = george;
                            largest[1] = i;
                            largest[2] = j;
                        }
                    }
                }
            }
            Console.WriteLine("The largest palindrome that can be made \nfrom the product of two 3-digit numbers is: "
                                + largest[0] + "\n\nWhich is the product of: " + largest[1] + " & " + largest[2]);
            return 0;//ghost, spooky
        }

    }
}
