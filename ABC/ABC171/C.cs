using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC171
{
    class C
    {
        static void Main(string[] args)
        {
            //var NK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var p = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = long.Parse(Console.ReadLine());
            char[] C = new char[26];
            C[0] = 'z';

            for (int i = 0; i < 25; i++)
            {
                C[i + 1] = (char)('a' + i);
            }
            //Console.WriteLine(string.Join(" ", C));

            string ans = "";
            //ans += C[N % 26];
            //long tempN = N / 26;
            long tempN = N;
            while (tempN > 0)
            {
                ans += C[tempN % 26];
                if(tempN % 26 == 0) tempN = tempN / 26 - 1;
                else tempN /= 26;
            }
            Console.WriteLine(string.Concat(ans.Reverse()));

        }
    }
}
