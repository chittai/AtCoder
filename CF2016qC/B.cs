using System;
using System.Linq;

namespace CF2016qC
{
    class B
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int K = input[0];
            int T = input[1];

            int[] a = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();

            int max = a[0];

            for (int i = 1; i < T; i++)
            {
                max -= a[i];
                if (max <= 0) { Console.WriteLine(0); return; }
            }

            Console.WriteLine(max - 1);
        }
    }
}
