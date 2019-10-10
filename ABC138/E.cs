using System;
using System.Collections.Generic;

namespace ABC138
{
    class E
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();

            Dictionary<char, List<long>> dict = new Dictionary<char, List<long>>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], new List<long>());
                    dict[s[i]].Add(i);
                }
                else if (dict.ContainsKey(s[i]))
                {
                    dict[s[i]].Add(i);
                }
            }

            // NGの時
            for (int i = 0; i < t.Length; i++)
            {
                if (!dict.ContainsKey(t[i])) { Console.WriteLine(-1); return; }
            }

            long current = -1;
            int index = 0;
            long turn = 0;

            foreach (var c in t)
            {
                var list = dict[c];

                index = list.BinarySearch(current + 1);
                if (index < 0) { index = ~index; }
                if (list.Count <= index) { index = 0; turn++; }

                current = list[index];
            }

            Console.WriteLine((long)s.Length * turn + current + 1);
        }
    }
}