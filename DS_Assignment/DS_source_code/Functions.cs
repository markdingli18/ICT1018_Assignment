using System;
using System.Collections.Generic;

namespace DS
{
    public static class Functions
    {
        //Question 10 find max of list using recusion
        public static int FindMaximumNumber(int[] A, int n)
        {
            // if size = 0 means whole array
            // has been traversed
            if (n == 1)
                return A[0];

            return Math.Max(A[n - 1], FindMaximumNumber(A, n - 1));
        }

        public static List<int> FindDuplicates(int[] numbers)
        {
            List<int> duplicated = new List<int>();
            Array.Sort(numbers);
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    duplicated.Add(numbers[i]);
                }
            }
            return duplicated;
        }

        // Question 4
        // Function to find out four elements
        // in array whose product is ab = cd
        public static void FindPairs(int[] arr, int n)
        {
            bool found = false;
            Dictionary<int, Pair> hp = new Dictionary<int, Pair>();

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int prod = arr[i] * arr[j];

                    if (!hp.ContainsKey(prod))
                    {
                        hp.Add(prod, new Pair(i, j));
                    }
                    else
                    {
                        Pair p = hp[prod];
                        Console.WriteLine("("+arr[p.first]+" x"
                                + " " + arr[p.second]+ ")"
                                + " " + "and" + " " + "(" +
                                arr[i] + " x" + " " + arr[j]+ ")"
                                + " have the same product.");
                        found = true;
                    }
                }
            }

            if (found == false)
            {
                Console.WriteLine("No pairs Found");
            }
        }

        public static float CalculateSin(float number)
        {
            float accuracy = (float)0.0001, denominator, sinx, sinval;

            // Converting degrees to radian
            number = number * (float)(3.142 / 180.0);

            float x1 = number;

            // maps the sum along the series
            sinx = number;

            // holds the actual value of sin(n)
            sinval = (float)Math.Sin(number);
            int i = 1;
            do
            {
                denominator = 2 * i * (2 * i + 1);
                x1 = -x1 * number * number / denominator;
                sinx = sinx + x1;
                i = i + 1;
            } while (accuracy <= sinval - sinx);

            return sinx;
        }

        public static float CalculateCos(float number)
        {
            float accuracy = (float)0.0001, x1, denominator, cosx, cosval;
            // Converting degrees to radian
            number = number * (float)(3.142 / 180.0);
            x1 = 1;
            // maps the sum along the series
            cosx = x1;
            // holds the actual value of sin(n)
            cosval = (float)Math.Cos(number);
            int i = 1;
            do
            {
                denominator = 2 * i * (2 * i - 1);
                x1 = -x1 * number * number / denominator;
                cosx = cosx + x1;
                i = i + 1;

            } while (accuracy <= cosval - cosx);

            return cosx;
        }

        // Inspired by: https://www.geeksforgeeks.org/sum-fibonacci-numbers/
        public static int FibonacciSequenceSum(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            int[] fibo = new int[n + 1];
            fibo[0] = 0; fibo[1] = 1;

            // Initialize result
            int sum = fibo[0] + fibo[1];
            Console.WriteLine($"{fibo[0]} + {fibo[1]} = {sum}");

            // Add remaining terms
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine($"Term {i}");
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                Console.WriteLine($"Term total = {fibo[i - 1]} + {fibo[i - 2]} = {fibo[i]}");
                sum += fibo[i];
                Console.WriteLine($"Sum = {sum} + {fibo[i]} = {sum}");
                Console.WriteLine("--------------------------------------------------------");
            }
           
            return sum;

        }

       //Inspired by: https://www.geeksforgeeks.org/print-stack-elements-from-top-to-bottom/
        public static void PrintStack(Stack<int> s)
        {
            // If stack is empty
            if (s.Count == 0)
                return;

            // Extract top of the stack
            int x = s.Peek();

            // Pop the top element
            s.Pop();

            // Print the current top
            // of the stack i.e., x
            Console.Write(x + " ");

            // Proceed to print
            // remaining stack
            PrintStack(s);

            // Push the element back
            s.Push(x);
        }
    }
}

