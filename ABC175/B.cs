using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC175
{
    class Program
    {
        static void Main(string[] args)
        {
            //var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            // var N = NK[0]; var K = NK[1];
            // var A = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            var N = long.Parse(Console.ReadLine());
            var L = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();

            var ans = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    for (int k = j + 1; k < N; k++)
                    {
                        if (L[i] != L[j] && L[j] != L[k] && L[k] != L[i])
                        {
                            if (L[i] + L[j] > L[k] && L[j] + L[k] > L[i] && L[k] + L[i] > L[j]) ans++;
                        }

                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
