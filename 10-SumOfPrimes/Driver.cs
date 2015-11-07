using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_SumOfPrimes
{
    class Driver
    {
        static void Main(string[] args)
        {
            Pretty bettie = new Pretty();
            bettie.primeGenesis(2000000);
            Console.ReadKey();
        }
    }
}
