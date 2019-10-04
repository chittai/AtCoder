using System;
using System.Collections;
using System.Collections.Generic;

namespace ABC138
{
    class D
    {

        static long[] Ans;
        static List<long>[] List;

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long N = long.Parse(input[0]);
            long Q = long.Parse(input[1]);

            List = new List<long>[N];
            for (long i = 0; i < N - 1; i++)
            {
                input = Console.ReadLine().Split();
                long a = long.Parse(input[0]) - 1;
                long b = long.Parse(input[1]) - 1;

                if (List[a] == null) List[a] = new List<long>();
                if (List[b] == null) List[b] = new List<long>();

                List[a].Add(b);
                List[b].Add(a);
            }

            Ans = new long[N];
            for (long i = 0; i < Q; i++)
            {
                input = Console.ReadLine().Split();
                long p = long.Parse(input[0]) - 1;
                long x = long.Parse(input[1]);
                Ans[p] += x;
            }

            Dfs(0, 0, 0);

            Console.WriteLine(string.Join(" ", Ans));

        }

        static void Dfs(long now, long parent, long sum)
        {
            Ans[now] += sum;
            foreach (var next in List[now])
            {
                if (next == parent) continue;
                Dfs(next, now, Ans[now]);
            }
        }
    }
}
