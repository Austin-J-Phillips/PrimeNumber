using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    public class PrimesTest
    {
        private const int CheckPrimeOption = 1;
        private const int ViewPrimesOption = 2;
        private const int ExitOption = 3;

        static void Main()
        {
            Primes primes = new Primes();

            Console.WriteLine("Prime Number Operations");
            Console.WriteLine();

            Console.WriteLine("1. Check if number is prime");
            Console.WriteLine("2. View first X prime numbers");
            Console.WriteLine("3. Exit");

            Console.Write("\nChoice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            switch (choice)
            {
                case CheckPrimeOption:
                    HandleCheckPrime(primes);
                    break;

                case ViewPrimesOption:
                    HandleViewPrimes(primes);
                    break;

                case ExitOption:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid input. Choice must be 1, 2, or 3.");
                    break;
            }
            Console.ReadKey();
        }

        static void HandleCheckPrime(Primes primes)
        {
            Console.Write("\nEnter a non-negative integer value: ");

            if (!int.TryParse(Console.ReadLine(), out int number) || number < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                return;
            }

            bool isPrime = primes.IsPrime(number);

            Console.WriteLine(isPrime
                ? $"{number} is a prime number."
                : $"{number} is not a prime number.");
        }

        static void HandleViewPrimes(Primes primes)
        {
            Console.Write("\nEnter a non-negative integer value: ");

            if (!int.TryParse(Console.ReadLine(), out int count) || count < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                return;
            }

            var primeNumbers = primes.GetPrimes(count);

            Console.WriteLine($"\nThe first {count} prime numbers are:");
            Console.WriteLine(string.Join(", ", primeNumbers));
        }
    }
}
