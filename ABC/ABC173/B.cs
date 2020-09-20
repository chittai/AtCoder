using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC173
{
    class B
    {
        static void Main(string[] args)
        {
            //var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var NMK = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = long.Parse(Console.ReadLine());
            var S = new string[N];
            var Count = new long[4];
            for (int i = 0; i < N; i++)
            {
                S[i] = Console.ReadLine();
                if (S[i] == "AC") Count[0]++;
                if (S[i] == "WA") Count[1]++;
                if (S[i] == "TLE") Count[2]++;
                if (S[i] == "RE") Count[3]++;
            }

            Console.WriteLine("AC x " + Count[0]);
            Console.WriteLine("WA x " + Count[1]);
            Console.WriteLine("TLE x " + Count[2]);
            Console.WriteLine("RE x " + Count[3]);

        }
    }
}
