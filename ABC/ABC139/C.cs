using System;
using System.Linq;

namespace ABC139
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] H = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int count = 0;
            int res = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (H[i + 1] <= H[i])
                {
                    count++;
                    res = Math.Max(res, count);
                }
                else
                {
                    count = 0;
                }
            }
            Console.WriteLine(res);
        }
    }
}
