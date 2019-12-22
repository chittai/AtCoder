using System;
using System.Linq;

namespace ABC148
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            long res = 0;
            long current = 0;
            for (int i = 0; i < N; i++)
            {
                if (current + 1 == a[i]) { current = a[i]; }
                else res++;
            }

            if (res == N) Console.WriteLine(-1);
            else Console.WriteLine(res);

        }
    }
}
