using System;
using System.Linq;

namespace ABC024
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int D = input[1];
            int K = input[2];

            int[,] LR = new int[D, 2];
            for (int i = 0; i < D; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                LR[i, 0] = input[0]; //L
                LR[i, 1] = input[1]; //R
            }

            int[] Res = new int[K];
            for (int i = 0; i < K; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int S = input[0];
                int T = input[1];
                int current = S;
                int count = 0;
                for (int j = 0; j < D; j++)
                {
                    count++;
                    if (LR[j, 0] <= current && current <= LR[j, 1] && S < T)
                    {
                        current = LR[j, 1];
                        if (T <= current) { break; }
                    }
                    else if (LR[j, 0] <= current && current <= LR[j, 1] && S > T)
                    {
                        current = LR[j, 0];
                        if (current <= T) { break; }
                    }
                }
                Res[i] = count;
            }
            foreach (var i in Res)
            {
                Console.WriteLine(i);
            }
        }
    }
}
