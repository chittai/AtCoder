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
            int[] arr = new int[100001];

            for (int left = 0; left < N; left++)
            {
                while (right < N && arr[A[right]] < 1)
                {
                    arr[A[right]]++;
                    right++;
                }

                res = Math.Max(res, right - left);

                if (right == left) right++;
                else arr[A[left]]--;
            }
            Console.WriteLine(res);
        }
    }
}
