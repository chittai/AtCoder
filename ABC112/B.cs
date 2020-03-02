using System;
using System.Linq;

namespace ABC112
{
    class B
    {
        static void Main(string[] args)
        {
            var NT = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var ct = Enumerable.Repeat(0, NT[0]).Select(_ => Console.ReadLine().Split().Select(int.Parse).ToArray()).ToArray();

            int res = int.MaxValue;
            for (int i = 0; i < NT[0]; i++)
            {
                if (ct[i][1] <= NT[1]) { res = Math.Min(res, ct[i][0]); }
            }

            if (res == int.MaxValue) Console.WriteLine("TLE");
            else Console.WriteLine(res);
        }
    }
}
