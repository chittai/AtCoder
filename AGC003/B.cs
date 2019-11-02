using System;
using System.Linq;
using System.Collections.Generic;

namespace AGC003
{
    class B
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());

            long[] A = new long[N];
            for (long i = 0; i < N; i++)
            {
                A[i] = long.Parse(Console.ReadLine());
            }

            long sum = 0;
            long count = 0;
            for (long i = 0; i < N; i++)
            {
                while (i < N && A[i] != 0)
                {
                    count += A[i];
                    i++;
                }
                sum += count / 2;
                count = 0;
            }
            Console.WriteLine(sum);
        }
    }
}
