using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public static class BigNumberCreator
    {
        static Dictionary<int, BigInteger> repository = new Dictionary<int, BigInteger>();

        public static BigInteger FetchNumber(int key)
        {
            // look ...
            if (repository.TryGetValue(key, out BigInteger big))
            {
                return big;
            }

            // create and store
            BigInteger biggy = (BigInteger)Math.Pow(2, key);
            repository[key] = biggy;

            return biggy;

        }

    }
}