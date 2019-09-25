using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC073
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //int[] A = new int[N];

            Dictionary<int, int> dict = new Dictionary<int, int>();
            int a = 0;
            for (int i = 0; i < N; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(a)) { dict.Add(a, 0); }
                if (dict.ContainsKey(a)) { dict[a]++; }
            }
            Console.WriteLine(dict.Count(x => (x.Value) % 2 != 0));
        }
    }
}
