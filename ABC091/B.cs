using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC091
{
    class B
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            Dictionary<string, int> dict = new Dictionary<string, int>();

            string s = "";
            for (int i = 0; i < N; i++)
            {
                s = Console.ReadLine();
                if (!dict.ContainsKey(s)) { dict.Add(s, 0); }
                if (dict.ContainsKey(s)) { dict[s]++; }
            }

            int M = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine();
                if (!dict.ContainsKey(s)) { dict.Add(s, 0); }
                if (dict.ContainsKey(s)) { dict[s]--; }
            }

            var res = dict.OrderByDescending(x => x.Value);

            if (res.First().Value < 0) Console.WriteLine(0);
            else Console.WriteLine(res.First().Value);
        }
    }
}
