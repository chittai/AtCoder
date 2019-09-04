using System;

namespace ABC133
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int D = int.Parse(input[1]);

            // 入力を二次元配列にすべて格納
            int[,] X = new int[N, D];
            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split(' ');
                for (int d = 0; d < D; d++)
                {
                    X[i, d] = int.Parse(input[d]);
                    //Console.WriteLine("x" + "[" + i + d + "]" + " : " + X[i, d]);
                }
            }

            // 経路を計算
            //int[] Ans = new int[N];
            int count = 0;
            for (int i = 0; i < N - 1; i++)
            {
                for (int k = i + 1; k < N; k++)
                {
                    double ans = 0;
                    for (int d = 0; d < D; d++)
                    {
                        ans += Math.Pow(Math.Abs(X[i, d] - X[k, d]), 2);
                    }
                    ans = Math.Sqrt(ans);
                    //Console.WriteLine("ans : " + ans);
                    if ((int)ans == ans)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
