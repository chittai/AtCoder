using System;
using System.Linq;
using System.Collections.Generic;

namespace TDPC
{
    class A
    {
        static List<int> list;
        static int[] p;
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            p = Console.ReadLine().Split().Select(int.Parse).ToArray();
            list = new List<int>();
            rec(N, 0);
            Console.WriteLine(list.Distinct().Count());

        }

        static private void rec(int N, int cost)
        {

            if (N == 0) { list.Add(cost); return; }
            rec(N - 1, cost + p[N - 1]);
            rec(N - 1, cost);
        }

    }
}
