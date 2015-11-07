using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Driver
    {
        public static void Main(string [] args)
        {
            Maths mathie = new Maths();
            mathie.diffOfSumofSquare(100);
            Console.ReadKey();
        }
    }
}
