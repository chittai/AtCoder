using System;

namespace ABC057
{
    class C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            long min = long.MaxValue;
            long B = 0;
            for (long i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    B = N / i;

                    min = Math.Min(min, CalculateTheNumberOfRows(B));
                }
            }

            Console.WriteLine(min);
        }

        static long CalculateTheNumberOfRows(long x)
        {
            long count = 0;
            while (0 < x)
            {
                x /= 10;
                count++;

            }
            return count;
        }
    }
}