using System;
using System.Linq;

namespace ABC144
{
    class C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            long x = 0;
            long y = 0;
            long min = long.MaxValue;
            for (long i = 1; i <= Math.Sqrt(N); i++)
            {
                if (N % i == 0)
                {
                    if (i + N / i < min)
                    {
                        x = i;
                        y = N / i;
                        min = i + N / i;
                    }
                }
            }
            Console.WriteLine(x + y - 2);
        }
    }
}