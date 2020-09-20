using System;
using System.Linq;

namespace ABC032
{
    class C
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long K = input[1];
            long[] s = new long[N];
            for (int i = 0; i < N; i++)
            {
                s[i] = long.Parse(Console.ReadLine());
            }

            long res = 0;
            long right = 0;
            long x = 1;

            if (s.Contains(0)) { Console.WriteLine(N); return; }


            for (int left = 0; left < N; left++)
            {
                while (right < N && x * s[right] <= K)
                {
                    x *= s[right];
                    right++;
                }

                res = Math.Max(res, right - left);

                if (right == left) right++;
                else if (s[left] == 0) { x = 0; res = left + 1; }
                else x /= s[left];

            }

            Console.WriteLine(res);
        }
    }
}
