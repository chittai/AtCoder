using System;
using System.Linq;

namespace ABC084
{
    class D
    {
        static void Main(string[] args)
        {
            int Q = int.Parse(Console.ReadLine());

            int[] l = new int[Q];
            int[] r = new int[Q];
            string[] input;
            for (int i = 0; i < Q; i++)
            {
                input = Console.ReadLine().Split(' ');
                l[i] = int.Parse(input[0]);
                r[i] = int.Parse(input[1]);
            }

            int Max = r.Max();
            int[] s = new int[Max + 1];
            s[0] = 0;
            for (int i = 1; i <= Max; i++)
            {
                if ((i % 2) != 0)
                {
                    // i が奇数
                    if (IsPrimeNumber(i) && IsPrimeNumber((i + 1) / 2))
                    {
                        s[i] = s[i - 1] + 1;
                    }
                }

                if (s[i] == 0)
                {
                    s[i] = s[i - 1];
                }
            }

            int k = 0;
            for (int j = 0; j < Q; j++)
            {
                k = s[r[j]] - s[l[j] - 1];
                if (r[j] == l[j] && (IsPrimeNumber(r[j]) && IsPrimeNumber((r[j] + 1) / 2))) { k = 1; }
                Console.WriteLine(k);
            }
        }

        static bool IsPrimeNumber(int number)
        {
            double i = number;

            // 平方根を求める
            double x = Math.Sqrt(i);

            // 平方根以下の値で割り切れるのか確認する
            // 最小値は2
            for (double j = 2; j <= x; j++)
            {
                if ((number % j) == 0) { return false; }
            }

            if (number == 1) { return false; }

            return true;

        }

    }
}