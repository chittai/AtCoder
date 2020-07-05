using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC173
{
    class B
    {
        static void Main(string[] args)
        {
            //var CA = Enumerable.Repeat(0, (int)N).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            //var HWK = long.Parse(Console.ReadLine());
            var HWK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var H = HWK[0]; var W = HWK[1]; var K = HWK[2];
            var HW = new char[H, W];
            var HWtmp = new char[H, W];
            for (int i = 0; i < H; i++)
            {
                var input = Console.ReadLine();
                for (int j = 0; j < W; j++)
                {
                    HW[i, j] = input[j];
                    HWtmp[i, j] = input[j];
                }
            }

            var ans = 0;
            // H
            for (int bit = 0; bit < (1 << H); bit++)
            {
                for (int bitW = 0; bitW < (1 << W); bitW++)
                {
                    // H
                    for (int i = 0; i < H; i++)
                    {
                        if ((bit & (1 << i)) > 0)
                        {
                            for (int j = 0; j < W; j++)
                            {
                                HWtmp[i, j] = '.';
                            }
                        }
                    }

                    // W
                    for (int j = 0; j < W; j++)
                    {
                        if ((bitW & (1 << j)) > 0)
                        {
                            for (int i = 0; i < H; i++)
                            {
                                HWtmp[i, j] = '.';
                            }
                        }
                    }

                    var sum = 0;
                    for (int i = 0; i < H; i++)
                    {
                        for (int j = 0; j < W; j++)
                        {
                            if (HWtmp[i, j] == '#') sum++;
                        }
                    }

                    if (sum == K) ans++;

                    for (int i = 0; i < H; i++)
                    {
                        for (int j = 0; j < W; j++)
                        {
                            HWtmp[i, j] = HW[i, j];
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
