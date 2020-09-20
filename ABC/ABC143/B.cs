using System;
using System.Linq;

namespace ABC143
{
    class B
    {
        static void Main(string[] args)
        {
            //int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            long N = long.Parse(Console.ReadLine());
            //string S = Console.ReadLine();
            long[] d = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long sum = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i != j) sum += (d[i] * d[j]);
                }
            }
            Console.WriteLine(sum / 2);
        }
    }
}
