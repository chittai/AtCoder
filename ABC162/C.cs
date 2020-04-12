using System;
using System.Linq;
using System.Collections.Generic;


namespace ABC162
{
    class B
    {
        static void Main(string[] args)
        {
            var K = int.Parse(Console.ReadLine());
            long sum = 0;
            for (int i = 1; i <= K; i++)
            {
                for (int j = 1; j <= K; j++)
                {
                    for (int k = 1; k <= K; k++)
                    {
                        sum += CalcGCD(CalcGCD(i, j), k);
                    }
                }
            }
            Console.WriteLine(sum);
        }
        public static long CalcGCD(long a, long b)
        {
            if (b == 0) { return a; }
            return CalcGCD(b, a % b);
        }

        public static long CalcLCM(long a, long b)
        {
            return a * b / CalcGCD(a, b);
        }
    }

}

