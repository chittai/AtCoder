using System;
using System.Linq;

namespace KEYENCE2020
{
    class A
    {
        static void Main(string[] args)
        {
            //long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //long N = long.Parse(Console.ReadLine());
            //string S = Console.ReadLine();

            int H = int.Parse(Console.ReadLine());
            int W = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int count = 0;
            if (H <= W)
            {
                for (int i = 0; i < H; i++)
                {
                    count += W;
                    if (N <= count) { Console.WriteLine(i + 1); return; }
                }
            }
            else
            {
                for (int i = 0; i < W; i++)
                {
                    count += H;
                    if (N <= count) { Console.WriteLine(i + 1); return; }
                }

            }
        }
    }
}
