using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC146
{
    class C
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long A = input[0];
            long B = input[1];
            long X = input[2];

            List<long> list = new List<long>();
            long N = 0;
            for (long i = 1; i <= 10; i++)
            {
                N = (X - B * i) / A;
                list.Add(N);
            }
            //Console.WriteLine(string.Join(",", list));
            //Console.WriteLine(list.Count);

            int num = 0;
            for (int i = 0; i < list.Count; i++)
            {
                long res = A * list[i] + B * list[i].ToString().Length;
                if (X < res)
                {
                    num = i + 1;
                }
            }


            if (1000000000 < list.Min())
            {
                Console.WriteLine(1000000000);
                return;
            }

            if (num < list.Count && 0 < list[num])
            {
                Console.WriteLine(list[num]);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
