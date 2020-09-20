using System;
using System.Linq;

namespace ABC104
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int D = input[0];
            int G = input[1];

            int[] p = new int[D];
            int[] c = new int[D];
            for (int i = 0; i < D; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                p[i] = input[0];
                c[i] = input[1];
            }

            long res = long.MaxValue;
            for (int bit = 0; bit < (1 << D); bit++)
            {
                long sum = 0;
                long num = 0;
                for (int i = 0; i < D; i++)
                {
                    if ((bit & (1 << i)) > 0)
                    {
                        sum += c[i] + p[i] * 100 * (i + 1);
                        num += p[i];
                    }
                }

                if (G <= sum)
                {
                    res = Math.Min(res, num);
                }
                else
                {
                    for (int i = D - 1; i >= 0; i--)
                    {
                        if ((bit & (1 << i)) > 0) continue;
                        for (int j = 0; j < p[i]; j++)
                        {
                            if (sum >= G) break;
                            sum += 100 * (i + 1);
                            num++;
                        }
                    }
                    res = Math.Min(res, num);
                }
            }
            Console.WriteLine(res);
        }
    }
}
