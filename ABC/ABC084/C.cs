using System;
using System.Linq;

namespace ABC084
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] C = new int[N];
            int[] S = new int[N];
            int[] F = new int[N];
            int[] input;
            for (int i = 0; i < N - 1; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                C[i] = input[0];
                S[i] = input[1];
                F[i] = input[2];
            }

            int[] Res = new int[N];
            int t = 0;
            for (int i = 0; i < N - 1; i++)
            {
                t = S[i] + C[i];
                for (int j = i + 1; j < N - 1; j++)
                {
                    if (t < S[j])
                    {
                        t = S[j] + C[j];
                    }
                    else
                    {
                        if (t % F[j] != 0) t += F[j] - t % F[j];
                        t += C[j];

                    }
                }
                Res[i] = t;
            }

            foreach (var i in Res)
            {
                Console.WriteLine(i);
            }
        }
    }
}
