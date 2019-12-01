using System;
using System.Linq;
using System.Collections.Generic;

namespace MSBPC2019
{
    class C
    {
        static void Main(string[] args)
        {
            long X = long.Parse(Console.ReadLine());
            int[] price = new int[] { 100, 101, 102, 103, 104, 105 };
            List<long> list = new List<long>();
            for (int bit = 0; bit < (1 << 6); bit++)
            {
                long sum = 0;
                for (int i = 0; i < 6; i++)
                {
                    if ((bit & (1 << i)) > 0)
                    {
                        sum += price[i];
                    }
                }
                list.Add(sum);
            }

            //Console.WriteLine(string.Join(",", list));
            //Console.WriteLine(list.Count);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != 0 && (X % list[i] == 0 || (X % list[i]) % 100 == 0)) { Console.WriteLine(1); return; }
            }
            Console.WriteLine(0);
        }
    }
}
