using System;
using System.Collections.Generic;
using System.Linq;

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

            //<--debug
            //for (int i = 0; i < t.Length; i++)
            //{
            //    Console.WriteLine(string.Join(" ", dict[t[i]]));
            //}
            //debug-->

            long count = 0;
            long current = 0;
            int index = 0;

            foreach (var c in t)
            {
                var list = dict[c];

                index = list.BinarySearch(current);
                if (index < 0) { index = ~index; }
                if (list.Count <= index) { index = 0; }

                if (list[index] < current)
                {
                    count += (long)s.Length - (current + 1) + list[index] + 1;
                    current = list[index];
                }
                else
                {

                    count += list[index] - current;
                    current = list[index];
                }
                //Console.WriteLine("count : " + count);
            }

            Console.WriteLine(count);
        }
    }
}
