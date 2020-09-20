using System;
using System.Linq;

namespace APC001
{
    class B
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] b = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long res = 0;
            for (long i = 0; i < N; i++)
            {
                res += Math.Max(0, (b[i] - a[i]) / 2) - Math.Max(0, a[i] - b[i]);
            }
            if (0 <= res) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
