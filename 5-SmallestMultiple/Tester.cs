//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
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

        static void Main(string[] args)
        {
            Multiples mul = new Multiples();
            mul.isDivisible();
            Console.ReadKey();
        }
    }
}
