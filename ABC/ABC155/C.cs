using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC155
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            //string[] S = new string[N];
            Dictionary<string, int> dic = new Dictionary<string, int>();
            for (int i = 0; i < N; i++)
            {
                string S = Console.ReadLine();
                if (!dic.ContainsKey(S)) { dic.Add(S, 1); }
                else dic[S]++;
            }

            int max = 0;
            foreach (var item in dic)
            {
                if (max < item.Value) max = item.Value;
            }

            List<string> list = new List<string>();
            foreach (var item in dic)
            {
                if (item.Value == max) list.Add(item.Key);
            }

            var array = list.ToArray();

            Array.Sort(array, StringComparer.OrdinalIgnoreCase);

            //Console.WriteLine("---");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}