using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC075
{
    class C
    {
        static bool[] visited;
        static bool[,] connect;
        static int N;
        static int M;
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            N = input[0];
            M = input[1];

            connect = new bool[N, N];
            visited = new bool[N];

            int[] a = new int[M];
            int[] b = new int[M];
            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                a[i] = input[0] - 1;
                b[i] = input[1] - 1;
                connect[a[i], b[i]] = true;
                connect[b[i], a[i]] = true;
            }

            int res = 0;
            for (int i = 0; i < M; i++)
            {
                connect[a[i], b[i]] = false;
                connect[b[i], a[i]] = false;
                for (int j = 0; j < N; j++) visited[j] = false;

                dfs(0);

                bool bridge = false;
                for (int j = 0; j < N; j++)
                {
                    if (visited[j] == false) bridge = true;
                }
                if (bridge) res++;

                connect[a[i], b[i]] = true;
                connect[b[i], a[i]] = true;
            }
            Console.WriteLine(res);
        }

        static void dfs(int n)
        {
            visited[n] = true;
            for (int i = 0; i < N; i++)
            {
                if (connect[n, i] == false) continue;
                if (visited[i] == true) continue;
                dfs(i);
            }
        }
    }
}
