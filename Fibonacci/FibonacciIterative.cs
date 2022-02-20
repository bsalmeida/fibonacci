namespace Fibonacci
{
    internal class FibonacciIterative
    {
        internal int Run(int n)
        {
            int result = 0;
            int previous = 1;

            for (int i = 0; i < n; i++)
            {
                var temp = result;
                result = previous;
                previous = temp + previous;
            }
            return result;
        }
    }
}
