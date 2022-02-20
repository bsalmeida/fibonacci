using System.Collections.Generic;

namespace Fibonacci
{
    internal class FibonacciWithMemoization
    {
        internal int Run(int n, Dictionary<int, int> map)
        {
            if (!map.ContainsKey(n))
            {
                map.Add(n, Run(n - 1, map) + Run(n - 2, map));
            }
            return map[n];
        }
    }
}
