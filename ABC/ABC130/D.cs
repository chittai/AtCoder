using System;
using System.Linq;

namespace ABC130
{
    class D
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long N = long.Parse(input[0]);
            long K = long.Parse(input[1]);

            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long right = 0;
            long sum = 0;
            long res = 0;
            for (long left = 0; left < N; left++)
            {
                while (right < N && sum + a[right] < K)
                {
                    sum += a[right];
                    right++;
                }
                res += N - right;

                if (right == left) right++;
                else sum -= a[left];

            }
            Console.WriteLine(res);
        }
    }
}
