using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DS.BST;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();

            #region 1
            //
            //int arrayATotal = 0, arrayBTotal = 0;
            //int[] arrayA = new int[256];
            //int[] arrayB = new int[300];
            //
            //int minimum = 0;
            //int maximum = 1024;
            //
            //while (arrayATotal == arrayBTotal)
            //{
            //    arrayA = Enumerable
            //        .Repeat(0, arrayA.Length)
            //        .Select(i => randNum.Next(minimum, maximum))
            //        .ToArray();
            //
            //    arrayB = Enumerable
            //        .Repeat(0, arrayB.Length)
            //        .Select(i => randNum.Next(minimum, maximum))
            //        .ToArray();
            //
            //    arrayATotal = arrayA.Sum();
            //    arrayBTotal = arrayB.Sum();
            //}
            //
            ////Shell sort
            //Sorting.ShellSort(ref arrayA, arrayA.Length);
            //Console.WriteLine("Shell sorted: ");
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    Console.WriteLine($"{arrayA[i]} ");
            //}
            //Console.WriteLine($"-------------------------------------------------");
            //
            ////Quick sort
            //Sorting.QuickSorting(ref arrayB, 0, arrayB.Length - 1);
            //Console.WriteLine("Quick sorted: ");
            //for (int i = 0; i < arrayB.Length; i++)
            //{
            //    Console.WriteLine($"{arrayB[i]} ");
            //}
            //Console.WriteLine($"-------------------------------------------------");
            //
            //Console.WriteLine($"Sum of array A: {arrayA.Sum()} and length of {arrayA.Length}");
            //Console.WriteLine($"Sum of array B: {arrayB.Sum()} and length of {arrayB.Length}");
            //Console.WriteLine($"-------------------------------------------------");
            //
            #endregion

            #region 2
            //
            //var arrayResult = Sorting.MergeArrays(arrayA, arrayB);
            //Console.WriteLine("Merge:");
            //for (int i = 0; i < arrayResult.Length; i++)
            //{
            //    Console.WriteLine($"{arrayResult[i]} ");
            //}
            //
            //Console.WriteLine($"-------------------------------------------------");
            //Console.WriteLine($"Total sum of array A and array B is: {arrayA.Sum() + arrayB.Sum()}");
            //Console.WriteLine($"Array result of Merged array C is: {arrayResult.Sum()} and has length of: {arrayResult.Length}");
            //Console.WriteLine($"-------------------------------------------------");
            //
            #endregion

            #region 3
            //// Inspired by https://stackoverflow.com/questions/67760895/c-finding-the-extreme-points-of-an-algorithm
            //
            //int[] nums = { 0, 5, 3, 6, 8, 7, 15, 9 };
            //bool sorted = true;
            //
            //Console.WriteLine($"Extreme points are:");
            //
            //for (int i = 1; i < nums.Length - 1; i++)
            //{
            //
            //    if (nums[i] > nums[i - 1] && nums[i] > nums[i + 1] || nums[i] < nums[i - 1] && nums[i] < nums[i + 1])
            //    {
            //        sorted = false;
            //        Console.WriteLine(nums[i]);
            //    }
            //}
            //
            //if (sorted) Console.WriteLine("SORTED");
            #endregion

            #region 4
            //// Inspired by https://www.geeksforgeeks.org/find-all-pairs-possible-from-the-given-array/
            //
            //int[] arrayQuestion4 = new int[100];
            //int count = 0;
            //while (count < arrayQuestion4.Length)
            //{
            //    int randomNumberQuestion4 = randNum.Next(1, 1024);
            //    // while loop, if already exists in array, generate a new random number
            //    while (arrayQuestion4.Contains(randomNumberQuestion4))
            //    {
            //        randomNumberQuestion4 = randNum.Next(1, 1024);
            //    }
            //
            //    //Output list
            //    Console.WriteLine(randomNumberQuestion4);
            //
            //    arrayQuestion4[count] = randomNumberQuestion4;
            //    count++;
            //}
            //Functions.FindPairs(arrayQuestion4, arrayQuestion4.Length);
            #endregion

            #region 5
            //// Inspired by https://iq.opengenus.org/arithmetic-expression-evaluation-using-stack/
            //
            //string equation = "6872-+*";
            //
            //// creating a stack
            //Stack<int> stack = new Stack<int>();
            //
            //for (int i = 0; i < equation.Length; i++)
            //{
            //    char x = equation[i];
            //
            //    // If the character is an operand, push it into the stack.
            //    if (int.TryParse(x.ToString(), out int res))
            //    {
            //        stack.Push(x - '0');
            //    }
            //    // If the character is an operator, pop the 2 top most elements
            //    // from the stack and perform the operation. Push the result back to the stack.
            //    else
            //    {
            //        Console.WriteLine("Stack before operations:");
            //        Functions.PrintStack(stack);
            //        Console.WriteLine(Environment.NewLine);
            //        int operand1 = stack.Pop();
            //        int operand2 = stack.Pop();
            //        switch (x)
            //        {
            //            case '+':
            //                stack.Push(operand2 + operand1);
            //                break;
            //            case '-':
            //                stack.Push(operand2 - operand1);
            //                break;
            //            case '*':
            //                stack.Push(operand2 * operand1);
            //                break;
            //            case '/':
            //                stack.Push(operand2 / operand1);
            //                break;
            //        }
            //        Console.WriteLine("Stack after operations:");
            //        // function to print stack
            //        Functions.PrintStack(stack);
            //        Console.WriteLine(Environment.NewLine);
            //    }
            //}
            //Console.WriteLine($"RPN: {stack.Pop()}");
            #endregion

            #region 6
            //
            ////Check if number is prime
            //
            //long question6 = 0;
            //
            //do{
            //Console.WriteLine("Check if prime number:");
            //question6 = Convert.ToInt64(Console.ReadLine());
            //
            //    if(question6 <= 0)
            //    {
            //        Console.WriteLine("Enter a number greater than 0!");
            //        Console.WriteLine("------------------------------------------");
            //    }
            //
            //} while(question6 <= 0); 
            //  
            //        if (question6.IsPrime())
            //        {
            //            Console.WriteLine("It is prime");
            //            Console.WriteLine("------------------------------------------");
            //        }
            //        else
            //        {
            //            Console.WriteLine("It is not prime");
            //            Console.WriteLine("------------------------------------------");
            //        }
            //
            //        //Sieve of Eratosthenes
            //        var ret = Algorithms.SieveofEratosthenes();
            //        Console.WriteLine($"There are {ret.Count} primes up to {ret.Maximum}");
            //
            #endregion

            #region 7
            //BTree binarySearchTree = new BTree();
            //Node root = new Node();
            //int question7 = 1;
            //
            //// Create a list 
            //List<int> bstNumbers = new List<int>();
            //
            //// User input
            //Console.WriteLine("Input numbers to form BST. Enter -1 to stop.");
            //
            //// User input validation
            //while (question7 > 0)
            //{
            //    question7 = Convert.ToInt32(Console.ReadLine());
            //    if (question7 > 0)
            //    {
            //        bstNumbers.Add(question7);
            //    }
            //}
            //
            //foreach (int number in bstNumbers.Distinct())
            //{
            //    binarySearchTree.Add(number);
            //}
            //binarySearchTree.Print();
            #endregion

            #region 8
            //long question8 = 0; 
            //do 
            //{ 
            //Console.WriteLine("Input number to check approximation to the square root:");
            //question8 = Convert.ToInt64(Console.ReadLine());
            //
            //    if(question8 <= 0)
            //    {
            //        Console.WriteLine("Enter a number greater than 0!");
            //        Console.WriteLine("--------------------------------------------------------");
            //    }
            //
            //} while (question8 <= 0);
            //
            //Console.WriteLine($"The value of the root is: {Algorithms.NewtonsSquareRoot(question8)}");
            //Console.ReadLine();
            #endregion

            #region 9
            //int question9 = 0;
            //List<int> question9Numbers = new List<int>();
            //Console.WriteLine("Input numbers and find repeated ones. Enter -1 to stop.");
            //while (question9 != -1)
            //{
            //    question9 = Convert.ToInt32(Console.ReadLine());
            //    if (question9 != -1)
            //    {
            //        question9Numbers.Add(question9);
            //    }
            //}
            //Console.WriteLine($"Repeated numbers are: {string.Join(", ", Functions.FindDuplicates(question9Numbers.ToArray()).Distinct())}");
            #endregion

            #region 10
            //int question10 = 0;
            //List<int> question10Numbers = new List<int>();
            //Console.WriteLine("Input numbers and find largest number. Enter -1 to stop.");
            //while (question10 != -1)
            //{
            //    question10 = Convert.ToInt32(Console.ReadLine());
            //    if (question10 != -1)
            //    {
            //        question10Numbers.Add(question10);
            //    }
            //}
            //Console.WriteLine($"Largest number is: {Functions.FindMaximumNumber(question10Numbers.ToArray(), question10Numbers.ToArray().Length)}");
            #endregion

            #region 11
            //Console.WriteLine("Input number to compute cosine or sine by taking the first n terms of the appropriate (Maclaurin?) series expansion");
            //int question11 = Convert.ToInt32(Console.ReadLine());
            //
            //int factorial = Enumerable.Range(1, question11).Aggregate(1, (x, y) => x * y);
            //Console.WriteLine($"Cos: {Functions.CalculateCos(factorial)}");
            //Console.WriteLine($"Sin: {Functions.CalculateSin(factorial)}");
            #endregion

            #region 12
            //
            //int question12 = -1;
            //
            //do {
            //    Console.WriteLine("Input number to find the sum of the first n numbers using the Fibonacci sequence.");
            //     question12 = Convert.ToInt32(Console.ReadLine());
            //
            // 
            //    // validating input
            //    if (question12 < 0){
            //
            //        Console.WriteLine("Enter number larger than 0!");
            //        Console.WriteLine("------------------------------------------------------------------------------------");       
            //    }
            //
            //}while (question12 < 0);
            //
            //Console.WriteLine($"Fibonacci sum: {Functions.FibonacciSequenceSum(question12)}");
            //
            #endregion

            Console.ReadLine();
        }
    }
}
