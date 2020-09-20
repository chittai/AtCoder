using System;
using System.Linq;

namespace ABC054
{
    class C
    {
        static bool[,] graph;
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];

            graph = new bool[N, N];
            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[input[0] - 1, input[1] - 1] = true;
                graph[input[1] - 1, input[0] - 1] = true;
            }

            bool[] visited = new bool[N];
            visited[0] = true;

            Console.WriteLine(DFS(0, N, visited));
        }

        static int DFS(int v, int N, bool[] visited)
        {
            bool all_visited = true;

            for (int i = 0; i < N; i++)
            {
                if (visited[i] == false) all_visited = false;
            }

            if (all_visited) return 1;

            int res = 0;
            for (int i = 0; i < N; i++)
            {
                if (graph[v, i] == false) continue;
                if (visited[i]) continue;

                visited[i] = true;
                res += DFS(i, N, visited);
                visited[i] = false;
            }
            return res;
        }
    }
}
