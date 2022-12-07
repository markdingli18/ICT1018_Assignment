using System;

namespace DS
{
    public static class Algorithms
    {

        // Inspired By: https://www.geeksforgeeks.org/sieve-of-eratosthenes/
        public static SOEReturnObject SieveofEratosthenes()
        {
            // calculate how many prime numbers there are from 2 up to a MAX.
            const int MAX = 200;

            // Create an array of boolean values indicating whether a number is prime.
            // Start by assuming all numbers are prime by setting them to true.
            bool[] primes = new bool[MAX + 1];
            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }

            // Loop through a portion of the array (up to the square root of MAX). If
            // it's a prime, ensure all multiples of it are set to false, as they
            // clearly cannot be prime.
            for (int i = 2; i < Math.Sqrt(MAX) + 1; i++)
            {
                if (primes[i - 1])
                {
                    for (int j = (int)Math.Pow(i, 2); j <= MAX; j += i)
                    {
                        primes[j - 1] = false;
                    }
                }
            }

            // Output the results
            int total = 0;
            for (int i = 2; i < primes.Length; i++)
            {
                if (primes[i - 1])
                {
                    Console.WriteLine(i);
                    total++;
                }
            }

            return new SOEReturnObject() { Count = total, Maximum = MAX };
        }

        // Inspired by: https://www.geeksforgeeks.org/find-root-of-a-number-using-newtons-method/#:~:text=Let%20N%20be%20any%20number,to%20be%20N%20or%201.
        public static double NewtonsSquareRoot(double num)
        {
            double EPSILON = 0.000000001;

            // Assuming the sqrt of n as n only
            double x = num;

            // The closed guess will be stored in the root
            double num_root;

            // To count the number of iterations
            int count = 0;

            while (true)
            {
                count++;

                // Calculating more closed x
                num_root = 0.5 * (x + (num / x));

                // Checking for closeness
                if (Math.Abs(num_root - x) < EPSILON)
                    break;

                // Updating the root
                x = num_root;
            }

            return num_root;
        }
    }
}

