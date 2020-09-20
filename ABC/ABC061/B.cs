using System;
using System.Linq;
using System.Collections.Generic;

/* Dictionaryの練習 */

namespace ABC061
{
    class B
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int N = input[0];
            int M = input[1];

            Dictionary<int, int> dict = new Dictionary<int, int>();

            int a = 0;
            int b = 0;

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                a = input[0];
                b = input[1];

                if (!dict.ContainsKey(a)) { dict.Add(a, 0); }
                if (!dict.ContainsKey(b)) { dict.Add(b, 0); }

                if (dict.ContainsKey(a)) { dict[a]++; }
                if (dict.ContainsKey(b)) { dict[b]++; }

            }

            var res = dict.OrderBy(x => x.Key);

            for (int i = 1; i <= N; i++)
            {
                if (!dict.ContainsKey(i)) Console.WriteLine(0);
                else Console.WriteLine(dict[i]);
            }
        }
    }
}
