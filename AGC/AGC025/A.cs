using System;

namespace AGC025
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int min = int.MaxValue;
            int sum = 0;
            int nA = 0;
            int nB = 0;

            for (int i = 1; i < N; i++)
            {
                nA = i;
                nB = N - i;
                while (0 < nA)
                {
                    sum += nA % 10;
                    nA = nA / 10;
                }

                while (0 < nB)
                {
                    sum += nB % 10;
                    nB = nB / 10;
                }

                min = Math.Min(min, sum);
                sum = 0;

            }

            Console.WriteLine(min);
        }
    }
}
