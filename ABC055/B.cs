using System;

namespace ABC055
{
    class B
    {
        static void Main(string[] args)
        {
            long N = int.Parse(Console.ReadLine());
            const long MOD = 1000000007;

            long power = 1;
            for (long i = 1; i <= N; i++)
            {
                power = (power * i) % MOD;
            }

            Console.WriteLine(power);
        }
    }
}
