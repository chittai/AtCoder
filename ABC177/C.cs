
using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace ABC177
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var sum = 0L;
            var ans = 0L;
            for (int i = 0; i < N - 1; i++)
            {
                sum += A[i];
                ans += (sum % 1000000007 * A[i + 1] % 1000000007);
            }
            Console.WriteLine(ans % 1000000007);
        }
    }
}
