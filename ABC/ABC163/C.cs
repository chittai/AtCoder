using System;
using System.Linq;

namespace ABC163
{
    class C
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var ans = new long[N];

            for (int i = 0; i < N - 1; i++)
            {
                ans[A[i - 1]]++;
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
}
