using System;

namespace ABC133
{
    class C
    {
        static void Main(string[] args)
        {
            long MOD = 2019;
            string[] input = Console.ReadLine().Split(' ');
            long L = long.Parse(input[0]);
            long R = long.Parse(input[1]);

            long min = MOD;
            for (long i = L; i <= R - 1; i++)
            {
                for (long j = i + 1; j <= R; j++)
                {
                    if (((i * j) % MOD) == 0)
                    {
                        Console.WriteLine(0);
                        return;
                    }

                    if (((i * j) % MOD) < min)
                    {
                        min = ((i * j) % MOD);
                    }
                }
            }
            Console.WriteLine(min);
        }
    }
}
