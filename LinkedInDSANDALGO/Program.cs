using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace APlusB
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //FirstProgrammingAssessment();
            //Pairwise();
            //RunFibonacci();
            RunLastDigitOfLargeFib();
        }


        #region GreedyLargestNumber

        #endregion
        #region Fibonacci
        public static void RunLastDigitOfLargeFib(long? n = null)
        {
            if (n == null)
                n = GetInputInt();

            Print(GetLastDigitOfLargeFib(n));
        }
        public static char GetLastDigitOfLargeFib(long? n = null)
        {
            if (n == null)
                n = GetInputInt();
            var nthFib = GetNthFibonacci(n);
            var last = nthFib.ToString().Trim().ToCharArray().Last();
            return last;
        }
        public static void RunFibonacci(long? n = null)
        {
            if (n == null)
                n = GetInputInt();

            Print(GetNthFibonacci(n));
        }

        public static long GetNthFibonacci(long? n = null)
        {
            if (n == null)
                n = GetInputInt();
            if (n > 1)
            {
                //n -= 1;
                return Fibonacci(n.GetValueOrDefault());
            }
            else
            {
                return n == 0 ? 0 : 1;
            }
        }
        public static long Fibonacci(long n)
        {
            var list = new List<long>(int.Parse(n.ToString()));
            list.AddRange(new List<long>() { 0, 1 });
            long secondLast = 0;
            long last = 1;
            for (long i = 1; i < n; i++)
            {
                var current = secondLast + last;
                list.Add(current);
                secondLast = last;
                last = current;
            }
            return list.Last();
        }
        public static long FibonacciSlow(long n)
        {
            if (n == 1 || n == 0)
                return n;
            else
                return Fibonacci(n - 2) + Fibonacci(n - 1);
        }
        #endregion
        public static void Pairwise()
        {
            GetInput();
            var arr = GetInputIntList();
            
            var ordered = arr?.OrderByDescending(x => x).ToList();
            long max = ordered[0] * ordered[1];
            Print(max);

        }
        public static void FirstProgrammingAssessment()
        {
            var input = Console.ReadLine();
            var ints = input.Split(' ');
            var int1 = int.Parse(ints[0]);
            var int2 = int.Parse(ints[1]);
            Console.WriteLine(int1 + int2);
        }

        private static string GetInput()
        {
            return Console.ReadLine() ?? "";
        }

        private static long? GetInputInt()
        {
            long result;
            long.TryParse(Console.ReadLine(), out result);
            return result;
        }

        private static List<long> GetInputIntList()
        {
            return Console.ReadLine().Split(' ').Select(x => long.Parse(x))?.ToList();
        }

        private static void Print<T>(T message)
        {
            Console.WriteLine(message?.ToString());
        }
    }

    
}