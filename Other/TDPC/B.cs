using System;
using System.Linq;

namespace TDPC
{
    class B
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int A = input[0];
            int B = input[1];
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] DP = new int[A + 1, B + 1];

            for (int l = A; l >= 0; l--)
            {
                for (int r = B; r >= 0; r--)
                {
                    if (l == A && r == B) continue;

                    if ((l + r) % 2 == 0)
                    {
                        // SENKO
                        if (l == A)
                        {
                            DP[l, r] = DP[l, r + 1] + b[r];

                        }
                        else if (r == B)
                        {
                            DP[l, r] = DP[l + 1, r] + a[l];
                        }
                        else
                        {
                            DP[l, r] = Math.Max(DP[l + 1, r] + a[l], DP[l, r + 1] + b[r]);
                        }
                    }
                    else
                    {
                        // KOUKO
                        if (l == A)
                        {
                            DP[l, r] = DP[l, r + 1];
                        }
                        else if (r == B)
                        {
                            DP[l, r] = DP[l + 1, r];
                        }
                        else
                        {
                            DP[l, r] = Math.Min(DP[l + 1, r], DP[l, r + 1]);

                        }
                    }
                }
            }

            Console.WriteLine(DP[0, 0]);

        }
    }
}
