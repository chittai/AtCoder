using System;
using System.Linq;

namespace AGC038
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int[] P = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] a = new int[K];
            int[] tmp = new int[K];

            int count = 1;
            for (int i = 0; i < P.Length - K + 1; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    a[j] = P[i + j];
                }
                tmp = a;
                if (!tmp.SequenceEqual(a.OrderBy(x => x).ToArray())) { count++; }
            }

            Console.WriteLine(count);

        }
    }
}
