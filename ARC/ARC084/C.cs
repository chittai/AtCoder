using System;
using System.Linq;
using System.Collections.Generic;

namespace ARC084
{
    class C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            long[] B = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            long[] C = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();

            long res = 0;
            for (int i = 0; i < N; i++)
            {
                long indexA = Array.BinarySearch(A, B[i]);
                indexA = LowerBound(A, B[i]);

                long indexC = Array.BinarySearch(C, B[i]);
                indexC = N - UpperBound(C, B[i]);
                res += indexA * indexC;
            }
            Console.WriteLine(res);
        }

        public static int LowerBound<T>(T[] a, T v)
        {
            return LowerBound(a, v, Comparer<T>.Default);
        }

        public static int LowerBound<T>(T[] a, T v, Comparer<T> cmp)
        {
            var l = 0;
            var r = a.Length - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                var res = cmp.Compare(a[mid], v);
                if (res == -1) l = mid + 1;
                else r = mid - 1;
            }
            return l;
        }

        public static int UpperBound<T>(T[] a, T v)
        {
            return UpperBound(a, v, Comparer<T>.Default);
        }

        public static int UpperBound<T>(T[] a, T v, Comparer<T> cmp)
        {
            var l = 0;
            var r = a.Length - 1;
            while (l <= r)
            {
                var mid = l + (r - l) / 2;
                var res = cmp.Compare(a[mid], v);
                if (res <= 0) l = mid + 1;
                else r = mid - 1;
            }
            return l;
        }

    }
}
