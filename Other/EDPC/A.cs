using System;
using System.Linq;

namespace EDPC
{
    class A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] h = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] DP = new int[N].Select(x => int.MaxValue).ToArray();
            DP[0] = 0;
            DP[1] = Math.Abs(h[1] - h[0]);
            for (int i = 2; i < N; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    DP[i] = Math.Min(DP[i], DP[i - j] + Math.Abs(h[i] - h[i - j]));
                }
            }
            Console.WriteLine(DP[N - 1]);
        }
    }
}
