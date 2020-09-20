using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC121
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long N = long.Parse(input[0]);
            long M = long.Parse(input[1]);

            Dictionary<long, long> dict = new Dictionary<long, long>();

            long A = 0;
            long B = 0;
            for (long i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split();
                A = long.Parse(input[0]);
                B = long.Parse(input[1]);

                if (!dict.ContainsKey(A)) { dict.Add(A, 0); }
                if (dict.ContainsKey(A)) { dict[A] += B; }
            }

            var res = dict.OrderBy(x => x.Key);

            long total = 0;
            foreach (var item in res)
            {
                if (M <= item.Value)
                {
                    total += item.Key * M;
                    break;
                }
                total += item.Key * item.Value;
                M -= item.Value;
            }
            Console.WriteLine(total);
        }
    }
}
