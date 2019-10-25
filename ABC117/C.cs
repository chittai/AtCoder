using System;
using System.Linq;

namespace ABC117
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];
            int[] X = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();

            int[] lr = new int[M - 1];

            for (int i = 0; i < M - 1; i++)
            {
                lr[i] = X[i + 1] - X[i];
            }

            lr = lr.OrderByDescending(x => x).ToArray();

            int res = 0;
            for (int i = N - 1; i < lr.Length; i++)
            {
                res += lr[i];
            }
            Console.WriteLine(res);
        }
    }
}
