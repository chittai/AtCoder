using System;
using System.Linq;
using System.Collections.Generic;

namespace CF2017qB
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] D = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int M = int.Parse(Console.ReadLine());
            int[] T = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<int, int> dictD = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                if (!dictD.ContainsKey(D[i])) { dictD.Add(D[i], 1); }
                else { dictD[D[i]]++; }
            }

            Dictionary<int, int> dictT = new Dictionary<int, int>();
            for (int i = 0; i < M; i++)
            {
                if (!dictT.ContainsKey(T[i])) { dictT.Add(T[i], 1); }
                else { dictT[T[i]]++; }
            }

            foreach (var i in dictT)
            {
                if (!dictD.ContainsKey(i.Key) || dictD[i.Key] < i.Value) { Console.WriteLine("NO"); return; }
            }

            Console.WriteLine("YES");
        }
    }
}
