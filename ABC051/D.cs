using System;

namespace ABC051
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_V = 110;
            const int MAX_E = 1100;
            // Warshall–Floyd Initialize

            int[,] dist = new int[MAX_V, MAX_E];
            for (int i = 0; i < MAX_V; i++)
            {
                for (int j = 0; j < MAX_V; j++)
                {
                    dist[i, j] = 1000000;
                }
                dist[i, i] = 0;
            }

            string[] input;
            input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            int[] a = new int[M];
            int[] b = new int[M];
            int[] c = new int[M];
            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split(' ');
                a[i] = int.Parse(input[0]) - 1;
                b[i] = int.Parse(input[1]) - 1;
                c[i] = int.Parse(input[2]);

                dist[a[i], b[i]] = c[i];
                dist[b[i], a[i]] = c[i];
            }

            // Warshall–Floyd
            for (int k = 0; k < N; k++)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        dist[i, j] = Math.Min(dist[i, j], dist[i, k] + dist[k, j]);

                    }
                }
            }

            int result = 0;
            for (int i = 0; i < M; i++)
            {
                if (c[i] > dist[a[i], b[i]]) result++;
            }
            Console.WriteLine(result);
        }
    }
}
