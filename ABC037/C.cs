using System;
using System.Linq;

namespace ABC037
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long[] S = new long[N + 1];
            S[0] = 0;
            for (int i = 0; i < N; i++)
            {
                S[i + 1] = S[i] + a[i];
                //Console.WriteLine(S[i + 1]);
            }

            long sum = 0;
            for (int i = 0; i < N - K + 1; i++)
            {
                sum += S[i + K] - S[i];
            }
            Console.WriteLine(sum);
        }
    }
}
