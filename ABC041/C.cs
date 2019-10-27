using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC041
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                d.Add(i, a[i]);
            }
            var d2 = d.OrderByDescending(x => x.Value);
            foreach (var i in d2)
            {
                Console.WriteLine(i.Key + 1);
            }
        }
    }
}
