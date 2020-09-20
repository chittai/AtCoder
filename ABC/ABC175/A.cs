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
            var S = Console.ReadLine();
            var ans = 0;
            /*
            for (int i = 0; i < 3; i++)
            {
                if(i == 0 && S[i] == 'R') ans++;
                else if(S[i-1] == 'R' && S[i] == 'R') ans++;
                
            }
            */

            if(S == "SSS") ans = 0;
            if(S == "RSS") ans = 1;
            if(S == "SRS") ans = 1;
            if(S == "SSR") ans = 1;
            if(S == "SRR") ans = 2;
            if(S == "RRS") ans = 2;
            if(S == "RSR") ans = 1;
            if(S == "RRR") ans = 3;

            Console.WriteLine(ans);
        }
    }
}
