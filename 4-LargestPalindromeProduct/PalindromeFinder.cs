//Find the largest palindrome made from the product of two 3-digit numbers.
//This class determines whether or not an integer is a palindrome
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class PalindromeFinder
    {

        private String target;

        //Convert integer to string, place in char array, reverse char array, convert to string
        public String reverse(int x)
        {
            target = x.ToString();
            char[] charArray = target.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //Test equality of new reversed string against orginal
        public Boolean isPalindrome(String x)
        {
            if (x.Equals(target))
            {
                return true;
            }
            return false;
        }

    }
}
