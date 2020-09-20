using System;
using System.Linq;

namespace DOWANGO006
{
    class B
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] x = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long[] dist = new long[N - 1];
            for (int i = 0; i < N - 1; i++)
            {
                dist[i] = x[i + 1] - x[i];
            }

            long res = 0;
            for (int i = 0; i < N - 1; i++)
            {
                res += dist[i] 

            }
            Console.WriteLine(string.Join(",", dist));
            Console.WriteLine(res);
        }
    }
}
