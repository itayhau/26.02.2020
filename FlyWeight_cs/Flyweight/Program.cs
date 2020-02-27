using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2^40, 2^80, 2^100
            long l = (long)Math.Pow(2, 40);
            int[] fly_weight = {  40, 80, 100, 200, 400 }; // ...........................

            PrintSequence(fly_weight);

            Console.WriteLine(l);
        }

        static void PrintSequence(int[] flyweight)
        {
            // actually need the big objects
            foreach (var item in flyweight)
            {
              Console.WriteLine(BigNumberCreator.FetchNumber(item));
            }
        }
    }
}
