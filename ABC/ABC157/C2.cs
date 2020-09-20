using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC157
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];
            int[] s = new int[M];
            int[] c = new int[M];

            if (1 < N && M == 0) { Console.WriteLine(-1); return; }
            if (N == 1 && M == 0) { Console.WriteLine(0); return; }

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                s[i] = input[0];
                c[i] = input[1];
                if (1 < N && s[i] == 1 && c[i] == 0) { Console.WriteLine(-1); return; }

            }

            int[] res = new int[N].Select(x => x = int.MaxValue).ToArray();
            for (int i = 0; i < M; i++)
            {
                if (res[s[i] - 1] != int.MaxValue && res[s[i] - 1] != c[i]) { Console.WriteLine(-1); return; }
                if (c[i] < res[s[i] - 1]) res[s[i] - 1] = c[i];
            }

            for (int i = 0; i < N; i++)
            {
                if (res[0] == int.MaxValue) res[0] = 1;
                if (res[i] == int.MaxValue) res[i] = 0;
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(res[i]);
            }
            Console.WriteLine();
        }
    }
}