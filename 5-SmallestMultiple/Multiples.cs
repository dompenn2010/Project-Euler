//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Multiples
    {
        int terminalTest = 20;
        int count = 0;

        public void isDivisible()
        {
            Console.Out.WriteLine("This might take a sec...");
            //Outer loop gives us the starting 
            for (int i = 1; i < 999999999; i++)
            {
                //
                for (int j = 1; j <= terminalTest; j++)
                {

                    if (i % j == 0)
                    {
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                    if (count == terminalTest) 
                    {
                        Console.Out.WriteLine("The smallest integer evenly divisible by 1 through " 
                                                + terminalTest + " is: " + i);
                        return;
                    }
                }


            }
        }
    }
}
