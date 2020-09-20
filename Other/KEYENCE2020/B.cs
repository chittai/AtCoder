using System;
using System.Linq;
using System.Collections.Generic;

namespace KEYENCE2020
{
    class B
    {
        static void Main(string[] args)
        {
            //long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //string S = Console.ReadLine();
            long N = long.Parse(Console.ReadLine());
            Tuple<long, long>[] t = new Tuple<long, long>[N];
            for (int i = 0; i < N; i++)
            {
                long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
                t[i] = Tuple.Create(input[0] - input[1], input[0] + input[1]);
            }
            t = t.OrderBy(x => x.Item2).ToArray();
            /*
            foreach (var item in t)
            {
                Console.WriteLine("{0} {1}", item.Item1, item.Item2);
            }
            */

            long res = 0;
            long end = int.MinValue;
            for (int i = 0; i < N; i++)
            {

                if (end <= t[i].Item1)
                {
                    res++;
                    end = t[i].Item2;
                }
            }
            Console.WriteLine(res);
        }
    }
}
