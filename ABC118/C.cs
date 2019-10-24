using System;
using System.IO;
using System.Linq;

namespace ABC118
{
    class C
    {
        static void Main(string[] args)
        {

            //StreamReader sr = new StreamReader(@"./testcase/in/testcase");
            long N = long.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).ToArray();
            //long N = long.Parse(sr.ReadLine());
            //long[] A = sr.ReadLine().Split().Select(long.Parse).OrderByDescending(x => x).ToArray();

            long res = A[0];
            for (long i = 1; i < N; i++)
            {
                res = gcd(res, A[i]);
            }

            Console.WriteLine(res);
        }

        static long gcd(long a, long b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }

    }
}
