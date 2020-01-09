using System;
using System.Linq;

namespace ABC118
{
    class B
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];

            int[] Ans = new int[M];
            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int K = input[0];
                for (int j = 1; j <= K; j++)
                {
                    Ans[input[j] - 1]++;
                }
            }

            int res = Ans.Count(x => x == N);
            Console.WriteLine(res);
        }
    }
}
