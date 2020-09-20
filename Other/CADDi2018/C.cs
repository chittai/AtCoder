using System;
using System.Linq;

namespace CADDi2018
{
    class C
    {
        static void Main(string[] args)
        {
            //input
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long P = input[1];

            if (N == 1) { Console.WriteLine(P); return; }

            long[] Array = new long[(int)Math.Ceiling(Math.Sqrt(P))];
            long p = P;
            long res = 1;
            for (int i = 2; i < Math.Sqrt(P); i++)
            {
                //素因数分解
                while (p % i == 0)
                {
                    Array[i]++;
                    p /= i;
                }
                Array[i] /= N;
                res *= (long)Math.Pow(i, Array[i]);
            }

            //Console.WriteLine(string.Join(",", Array));
            Console.WriteLine(res);
        }
    }
}
