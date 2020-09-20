using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC166
{
    class E
    {
        static void Main(string[] args)
        {
            var N = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var ans = 0L;
            Dictionary<long, long> dictL = new Dictionary<long, long>();
            //Dictionary<long, long> dictR = new Dictionary<long, long>();

            for (long i = 0; i < N - 1; i++)
            {
                if (!dictL.ContainsKey(i + A[i])) dictL.Add(i + A[i], 1);
                else dictL[i + A[i]]++;
            }

            for (long i = 1; i < N; i++)
            {
                if (dictL.ContainsKey(i - A[i])) ans += dictL[i - A[i]];
            }
            Console.WriteLine(ans);
        }
    }
}
