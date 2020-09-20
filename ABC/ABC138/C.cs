using System;

namespace ABC138
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            int[] v = new int[N];

            for (int i = 0; i < N; i++)
            {
                v[i] = int.Parse(input[i]);
            }

            Array.Sort(v);

            double res = 0;
            res += v[0] / Math.Pow(2, N - 1);
            res += v[1] / Math.Pow(2, N - 1);
            for (int i = 2; i < N; i++)
            {
                res += v[i] / Math.Pow(2, N - i);
            }
            Console.WriteLine(res);
        }
    }
}
