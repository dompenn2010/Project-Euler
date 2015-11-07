using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _012___HighlyDivisbleTriNum
{
    class TriNum1
    {

        //static ArrayList triNum = new ArrayList();
        Boolean found = false;
        int nThNum;
        static ArrayList triNumList = new ArrayList();
        int triNumCount = 1;
        int divisorCount = 0;

        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            TriNum1 tri = new TriNum1();
            tri.triGen();

            stopWatch.Stop();
            Console.Out.WriteLine("Computed in: " + stopWatch.Elapsed);
            Console.ReadKey();
        }

        //generate n triangle numbers
        public void triGen()
        {

            //add all numbers of the triangle to an Arraylist
            while (!found)
            {
               /* for (int i = 1; i <= triNumCount; i++)
                {
                    triNumList.Add(i);

                }
                */

                triNumList.Add(triNumCount);
            
                //Sum of all entries in arraylist is the "name" of the triNum *working
                foreach (int i in triNumList)
                {
                    nThNum += i;

                }

                findFactors(triNumList);

            }
        }

        //Get all factors of the arraylist
        public void findFactors(ArrayList x)
        {


            for (int i = 1; i <= nThNum; i++)
            {
                if (nThNum % i == 0)
                {
                    divisorCount++;

                }
            }
           // if (triNumList.Count > 5)
            //{
                if (divisorCount > 5)
                {

                    Console.Out.WriteLine("Oh shit");
                    Console.Out.WriteLine(nThNum);


                    found = true;
                }
                else
                {
                    nThNum = 0;

                    divisorCount = 0;
                    triNumCount++;

                }
        //    }




        }
    }
}
