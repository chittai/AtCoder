using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC167
{
    class C
    {
        static void Main(string[] args)
        {
            var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NK[0]; var K = NK[1];
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var B = new long[N + 1]; // N回目の移動でいるます
            var Visited = new bool[N];
            B[0] = 1;
            Visited[0] = true;
            for (int i = 1; i < N + 1; i++)
            {
                B[i] = A[B[i - 1] - 1];
            }

            long index = 0;
            for (int i = 1; i < N + 1; i++)
            {
                if (!Visited[B[i] - 1]) Visited[B[i] - 1] = true;
                else { index = i; break; }
            }
            var num = B[index];
            //Console.WriteLine(num);
            //Console.WriteLine(index);

            long start = 0;
            for (int i = 0; i < N + 1; i++)
            {
                if (B[i] == num) { start = i; break; }
            }
            //Console.WriteLine(start);

            // start 番目に num がでる
            // idnex 番目に num がまたでる
            K = (K - start) % (index - start);
            var ans = B[start + K];
            Console.WriteLine(ans);
        }
    }
}

