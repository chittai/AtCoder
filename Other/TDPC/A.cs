using System;
using System.Linq;

namespace TDPC
{
    class A
    {
        static int[] p;
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            p = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = p.Sum();

            bool[] dp = new bool[sum + 110];
            dp[0] = true;

            for (int i = 0; i < N; i++)
            {
                for (int j = sum; 0 <= j; j--)
                {
                    if (dp[j] | dp[j + p[i]]) { dp[j + p[i]] = true; }
                }
            }
            Console.WriteLine(dp.Count(x => x == true));
        }
    }
}
