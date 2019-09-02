using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC137
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, long> dic = new Dictionary<string, long>();
            string[] ss = new string[N];

            for (int i = 0; i < N; i++)
            {
                string s = Console.ReadLine();
                ss[i] = String.Concat(s.OrderBy(a => a));
            }

            for (int i = 0; i < N; i++)
            {
                if (dic.ContainsKey(ss[i]))
                {
                    dic[ss[i]]++;
                }
                else
                {
                    dic.Add(ss[i], 0);
                }
            }

            long res = 0;
            foreach (int i in dic.Values)
            {
                long temp = i;
                while (1 <= temp)
                {
                    res += temp;
                    temp--;
                }
            }
            Console.WriteLine(res);
        }
    }
}
