
using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace ABC177
{
    class Program
    {
        static void Main(string[] args)
        {
            var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = NM[0]; var M = NM[1];
            var CA = Enumerable.Repeat(0, (int)M).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();

            var group = new long[N];
            var gnum = 1L;

            // Console.WriteLine(CA[0][0]);

            for (int i = 0; i < M; i++)
            {
                if (group[CA[i][0] - 1] == 0 && group[CA[i][1] - 1] == 0)
                {
                    group[CA[i][0] - 1] = gnum;
                    group[CA[i][1] - 1] = gnum;
                    gnum++;
                }
                else
                {
                    if (group[CA[i][0] - 1] == 0) group[CA[i][0] - 1] = group[CA[i][1] - 1];
                    if (group[CA[i][1] - 1] == 0) group[CA[i][1] - 1] = group[CA[i][0] - 1];
                }
            }
            //Console.WriteLine(string.Join(" ", group));

            var gcount = new long[N];
            for (int i = 0; i < N; i++)
            {
                if (group[i] != 0) gcount[group[i] - 1]++;
            }

            gcount = gcount.OrderBy(x => x).ToArray();

            //Console.WriteLine(string.Join(" ", gcount));

            var sum = 0L;
            var isFirst = true;
            for (int i = 0; i < N; i++)
            {
                if (gcount[i] == 0) continue;
                if (isFirst) { sum += gcount[i]; isFirst = false; continue; }
                sum += gcount[i] - sum;
            }

            //Console.WriteLine(string.Join(" ", group));
            if (sum == 0) sum = 1;
            Console.WriteLine(sum);

        }
    }
}
