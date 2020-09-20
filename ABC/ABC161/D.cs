using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC161
{
    class D
    {
        static List<long> res;
        static int k;
        static void Main(string[] args)
        {
            k = int.Parse(Console.ReadLine());
            res = new List<long>();
            BFS("");
            res.Sort();
            //Console.WriteLine(string.Join(",", res));
            res.Sort();
            //Console.WriteLine(res.Count);
            Console.WriteLine(res[k - 1]);
        }

        static void BFS(string s)
        {
            Queue<string> tq = new Queue<string>();
            if (s.Length == 0)
            {
                for (int i = 1; i < 10; i++)
                {
                    tq.Enqueue(i.ToString());
                    res.Add(i);
                }
            }
            else
            {
                tq.Enqueue(s);
                res.Add(long.Parse(s));
            }

            if (10 <= s.Length) { return; }
            while (0 < tq.Count)
            {
                var q = tq.Dequeue();
                var d = (q[q.Length - 1] - '0') - 1;
                var d2 = (q[q.Length - 1] - '0');
                var d3 = (q[q.Length - 1] - '0') + 1;
                if (0 <= d) BFS(q + d);
                BFS(q + d2);
                if (d3 < 10) BFS(q + d3);
            }
        }
    }
}
