using System;

namespace ARC067
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int temp;
            int j;
            int[] Res = new int[N + 1];

            for (int i = N; i > 1; i--)
            {
                j = 2;
                temp = i;
                while (j <= N)
                {
                    while (temp % j == 0)
                    {
                        Res[j]++;
                        temp /= j;
                    }
                    j++;
                }
            }

            long count = 1;
            for (int i = 2; i <= N; i++)
            {
                count *= Res[i] + 1;
                count %= 1000000007;
            }

            Console.WriteLine(count);
        }
    }
}
