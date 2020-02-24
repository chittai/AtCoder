using System;
using System.Linq;
using System.Collections.Generic;

namespace ARC022
{
    class B
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long right = 0;
            long res = 0;
            List<long> list = new List<long>();

            for (int left = 0; left < N; left++)
            {
                while (right < N && !list.Contains(A[right]))
                {
                    list.Add(A[right]);
                    right++;
                }

                res = Math.Max(res, right - left);

                if (right == left) right++;
                else list.RemoveAt(0);
            }
            Console.WriteLine(res);
        }
    }
}
