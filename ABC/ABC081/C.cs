using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC081
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                if (!dict.ContainsKey(A[i])) { dict.Add(A[i], 0); }
                if (dict.ContainsKey(A[i])) { dict[A[i]]++; }
            }
            if (dict.Count <= K) { Console.WriteLine(0); }
            else
            {
                int count = 0;
                var res = dict.OrderBy(x => x.Value);
                int index = 0;
                foreach (var item in res)
                {
                    if (index == dict.Count - K) break;
                    count += item.Value;
                    index++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
