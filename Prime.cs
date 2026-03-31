using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class Primes
    {
        public bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            if (number == 2)
                return true;

            if (number % 2 == 0)
                return false;

            int limit = (int)Math.Sqrt(number);

            for (int i = 3; i <= limit; i += 2)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public List<int> GetPrimes(int numberOfPrimes)
        {
            List<int> primes = new List<int>();

            int num = 2;

            while (primes.Count < numberOfPrimes)
            {
                if (IsPrime(num))
                {
                    primes.Add(num);
                }
                num++;
            }

            return primes;
        }
    }
}
