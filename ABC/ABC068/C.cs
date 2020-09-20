using System;
using System.Linq;

namespace ABC068
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];

            bool[] S = new bool[200010];
            bool[] G = new bool[200010];

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int a = input[0];
                int b = input[1];
                if (a == 1) S[b] = true;
                if (b == N) G[a] = true;
            }

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] && G[i]) { Console.WriteLine("POSSIBLE"); return; }
            }
            Console.WriteLine("IMPOSSIBLE");
        }
    }
}
