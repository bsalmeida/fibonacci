using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Fibonacci
{
    public class Program
    {
        private const int TIMES = 100000;

        public static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");

            var n = new Random().Next(20);
            Console.WriteLine($"n = {n}");
            
            var stopwatch = new Stopwatch();

            // Fibonacci
            var fib = new FibonacciIterative();
            Console.WriteLine($"Fibonacci({n}) = {fib.Run(n)}");

            stopwatch.Start();
            for (int i = 0; i < TIMES; i++)
            {
                fib.Run(n);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time : {stopwatch.ElapsedMilliseconds} ms");

            // Fibonacci Recursive
            var fibRec = new FibonacciRecursive();
            Console.WriteLine($"FibonacciRecursive({n}) = {fibRec.Run(n)}");

            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < TIMES; i++)
            {
                fibRec.Run(n);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time : {stopwatch.ElapsedMilliseconds} ms");

            // Fibonacci With Memoization
            var map = new Dictionary<int, int>() { { 0, 0 }, { 1, 1 } };
            var fibMem = new FibonacciWithMemoization();
            Console.WriteLine($"FibonacciWithMemoization({n}) = {fibMem.Run(n, map)}");

            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < TIMES; i++)
            {
                map = new Dictionary<int, int>() { { 0, 0 }, { 1, 1 } };
                fibMem.Run(n, map);
            }
            stopwatch.Stop();
            Console.WriteLine($"Time : {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
