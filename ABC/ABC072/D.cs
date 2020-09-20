using System;
using System.Linq;

namespace ABC072
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] P = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int res = 0;
            for (int i = 0; i < N; i++)
            {
                if (P[i] == i + 1)
                {
                    if (i < N - 1)
                    {
                        int tmp = P[i + 1];
                        P[i + 1] = P[i];
                        P[i] = tmp;
                    }
                    res++;
                }
            }
            Console.WriteLine(res);
        }
    }
}
