using System;
using System.Linq;

namespace ABC116
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] h = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long count = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (h[i + 1] < h[i]) count += h[i] - h[i + 1];
            }

            count += h[N - 1];

            Console.WriteLine(count);
        }
    }
}
