using System;
using System.Linq;
using System.Collections.Generic;


namespace ABC127_1
{
    class D
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var N = a[0];
            var M = a[1];
            var A = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            var BC = Enumerable.Repeat(0, (int)M).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).OrderByDescending(x => x[1]).ToArray();

            var index = 0;
            for (long i = 0; i < N;)
            {
                var count = 0;
                while (index < M && i < N && count < BC[index][0])
                {
                    if (A[i] < BC[index][1]) A[i] = BC[index][1];
                    else break;
                    i++;
                    count++;
                }
                index++;
                if (M <= index) break;
            }
            //Console.WriteLine(string.Join(",", A));

            Console.WriteLine(A.Sum());
        }
    }
}
