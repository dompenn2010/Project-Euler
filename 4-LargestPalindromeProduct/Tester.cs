//Find the largest palindrome made from the product of two 3-digit numbers.
//This class drives the program
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Tester
    {
        public static PalindromeFinder pally;

        static void Main(string[] args)
        {
            //Initialize the Numbergen and PalindromeFinder classes
            NumberGen nums = new NumberGen();
            pally = new PalindromeFinder();
            //Start your engines!
            nums.generator();
            Console.ReadKey();
        }
    }
}
