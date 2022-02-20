namespace Fibonacci
{
    internal class FibonacciRecursive
    {
        internal int Run(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Run(n - 1) + Run(n - 2);
        }
    }
}
