using System;
using System.Collections.Generic;

namespace IEnumerablePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Practice[] practiceArray = new Practice[3]
            {
                new Practice(1, 2),
                new Practice(3,4),
                new Practice(5,6),
            };

            Practices practicesList = new Practices(practiceArray);

            IEnumerable<Practice> seconPractices = practiceArray;

            foreach (Practice p in practicesList)
            {
                Console.WriteLine(p.Value1 + " , " + p.Value2);
            }

            foreach (Practice p in seconPractices)
            {
                Console.WriteLine(p.Value1 + " , " + p.Value2);
            }

            /* This code produces output similar to the following:
             *
             * 1 , 2
             * 3 , 4
             * 5 , 6
             * 1 , 2
             * 3 , 4
             * 5 , 6
             *
             */
        }
    }
}

