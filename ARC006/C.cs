using System;
using System.Linq;
using System.Collections.Generic;

namespace ARC006
{
    class C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            List<long> list = new List<long>();
            for (int i = 0; i < N; i++)
            {
                long w = long.Parse(Console.ReadLine());
                long min = long.MaxValue;
                int index = -1;

                if (list.Count == 0) { list.Add(w); }
                else
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        long m = list[j] - w;
                        if (0 <= m && m < min)
                        {
                            index = j;
                            min = m;
                        }
                    }
                    if (-1 < index) list[index] = w;
                    else list.Add(w);
                }
            }
            //Console.WriteLine(string.Join(",", list));
            Console.WriteLine(list.Count);
        }
    }
}
