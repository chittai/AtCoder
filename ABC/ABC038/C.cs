using System;
using System.Linq;

namespace ABC038
{
    class C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long res = 0;
            long right = 0;
            for (int left = 0; left < N; left++)
            {
                while (right < N - 1 && a[right] < a[right + 1])
                {
                    right++;
                }

                res += right - left;

                if (right == left) right++;
            }
            Console.WriteLine(res + N);
        }
    }
}
