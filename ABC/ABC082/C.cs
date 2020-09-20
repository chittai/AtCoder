using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC082
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                if (!dict.ContainsKey(a[i])) { dict.Add(a[i], 1); }
                else { dict[a[i]]++; }
            }

            long res = 0;
            foreach (var i in dict)
            {
                if (i.Key <= i.Value) res += i.Value - i.Key;
                else res += i.Value;
            }
            Console.WriteLine(res);
        }
    }
}
