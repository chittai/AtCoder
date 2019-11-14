using System;
using System.Linq;

namespace ARC059
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = a.Sum();
            int c = 0;
            if (sum % N == 0) c = sum / N;
            else if ((double)N / 2d < sum % N) c = sum / N + 1;
            else c = sum / N;

            double res = 0;
            for (int i = 0; i < N; i++)
            {
                res += Math.Pow(a[i] - c, 2);
            }
            Console.WriteLine(res);
        }
    }
}
