using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ABC170
{
    class D
    {
        static void Main(string[] args)
        {
            //var XN = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var input = Console.ReadLine();
            // var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var AB = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var N = long.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();

            if (A[0] == 1)
            {
                Console.WriteLine(0);
                return;
            }

            var ans = 0;
            //var isTwo = false;
            //if (A.Contains(2)) { isTwo = true; }
            var count = new long[A.Max() + 10];

            for (int i = 0; i < A.Length; i++)
            {
                count[A[i]]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                if (count[i] == 1)
                {
                    if (IsPrime(i))
                    {
                        ans++;
                    }
                    else
                    {
                        var exist = false;
                        for (int j = 1; j <= Math.Sqrt(i); j++)
                        {
                            if (1 <= count[j] || 1 <= count[i / j])
                            {
                                exist = true;
                            }
                        }
                        if (!exist) ans++;
                    }

                }
            }
            Console.WriteLine(ans);
        }

        public static bool IsPrime(long num)
        {
            if (num < 2) return false;
            else if (num == 2) return true;
            else if (num % 2 == 0) return false; // 偶数はあらかじめ除く

            double sqrtNum = Math.Sqrt(num);
            for (int i = 3; i <= sqrtNum; i += 2)
            {
                if (num % i == 0)
                {
                    // 素数ではない
                    return false;
                }
            }
            // 素数である
            return true;
        }

    }
}
