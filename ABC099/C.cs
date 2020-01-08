using System;
using System.Linq;

namespace ABC099
{
    class C
    {
        static int[] memo;
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            memo = new int[N + 1000].Select(x => -1).ToArray();

            Console.WriteLine(rec(N));
        }

        static int rec(int n)
        {
            if (n == 0) return 0;
            if (memo[n] != -1) return memo[n];

            int res = n;
            for (int i = 1; i <= n; i *= 6) res = Math.Min(res, rec(n - i) + 1);
            for (int i = 1; i <= n; i *= 9) res = Math.Min(res, rec(n - i) + 1);

            memo[n] = res;
            return memo[n];
        }
    }
}
