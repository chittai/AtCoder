using System;
using System.Linq;

namespace ABC087
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] A2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] A1S = new int[N + 1];
            int[] A2S = new int[N + 1];

            int[] S = new int[N + 1];

            A1S[0] = 0;
            A2S[0] = 0;
            for (int i = 1; i < N + 1; i++)
            {
                A1S[i] = A1S[i - 1] + A1[i - 1];
                A2S[i] = A2S[i - 1] + A2[i - 1];
            }

            for (int i = 0; i < N; i++)
            {
                S[i] = A1S[i + 1] + A2S[N] - A2S[i];
            }

            Console.WriteLine(S.Max());
        }
    }
}
