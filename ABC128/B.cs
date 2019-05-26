using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC128
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int N = int.Parse(s);

            string[] s1;

            Dictionary<int, string> dic = new Dictionary<int, string>();
            Dictionary<int, int> dic2 = new Dictionary<int, int>();

            for (int i = 0; i < N; i++)
            {
                s1 = Console.ReadLine().Split(' ');
                dic.Add(int.Parse(s1[1]), s1[0]);

                dic2.Add(int.Parse(s1[1]), i);
            }

            var SortedDic = dic.OrderBy(x => x.Value).ThenByDescending(x => x.Key);

            foreach (var v in SortedDic)
            {
                Console.WriteLine(dic2[v.Key] + 1);
            }

        }
    }
}
