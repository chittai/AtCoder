using System;
using System.Linq;
using System.Collections.Generic;

namespace CF2016F
{
    class B
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            List<long> list = new List<long>();
            long res = 0;
            for (int i = 1; i <= N; i++)
            {
                res += i;
                list.Add(i);
                if (N < res) break;
            }

            long sum = list.Sum();
            list.Remove(sum - N);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
