using System;
using System.Linq;

namespace CF2017qA
{
    class B
    {
        static void Main(string[] args)
        {
            //input
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];
            int K = input[2];

            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= M; j++)
                {
                    if (i * (M - j) + j * (N - i) == K) { Console.WriteLine("Yes"); return; }
                }
            }
            Console.WriteLine("No");
        }
    }
}
