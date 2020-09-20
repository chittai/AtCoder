using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC128_1
{
    class B
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            //var b = Enumerable.Repeat(0, a).Select(_ => Console.ReadLine().Split().Select(int.Parse).ToArray()).OrderBy(x => x[0]).ThenByDescending(x => x[1]).ToArray();
            var t = new List<Tuple<int, string, int>>();
            for (int i = 0; i < a; i++)
            {
                var b = Console.ReadLine().Split().ToArray();
                var s = b[0];
                var p = int.Parse(b[1]);

                t.Add(Tuple.Create(i + 1, s, p));
            }

            t = t.OrderBy(x => x.Item2).ThenByDescending(x => x.Item3).ToList();
            foreach (var i in t)
            {
                Console.WriteLine(i.Item1);
            }
        }
    }
}
