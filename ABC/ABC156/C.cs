using System;
using System.Linq;
namespace ABC156
{
    class C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long[] X = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long res = int.MaxValue;
            for (int i = 0; i < 100; i++)
            {
                long sum = 0;
                for (int j = 0; j < N; j++)
                {
                    sum += (long)Math.Pow(X[j] - i, 2);
                }
                res = Math.Min(res, sum);
            }
            Console.WriteLine(res);
        }
    }
}
