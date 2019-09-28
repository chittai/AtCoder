using System;

namespace ABC142
{
    class D
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long A = long.Parse(input[0]);
            long B = long.Parse(input[1]);

            long N = CalcGCD(A, B);
            double sqrt = Math.Sqrt(N);

            long count = 1;
            long n = 2;

            bool isFirst = true;
            while (n <= sqrt)
            {
                if (N % n == 0)
                {
                    N /= n;
                    if (isFirst) { count++; isFirst = false; }
                }
                else
                {
                    isFirst = true; n++;
                }
            }
            if (N != 1) count++;
            Console.WriteLine(count);
        }

        static long CalcGCD(long a, long b)
        {
            if (b == 0) { return a; }
            return CalcGCD(b, a % b);
        }
    }
}
