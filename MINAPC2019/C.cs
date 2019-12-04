using System;
using System.Linq;

namespace MINAPC2019
{
    class C
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long K = input[0];
            long A = input[1];
            long B = input[2];

            if (K < A)
            {
                Console.WriteLine(K + 1);
            }
            else if (A <= K)
            {
                if (B <= A) Console.WriteLine(K + 1);
                else if (A < B)
                {
                    long count = 1;
                    long ope = 0;
                    while (ope < K)
                    {
                        if (ope < K - 1 && A <= count && 2 <= B - A) { count -= A; count += B; ope += 2; }
                        else { count++; ope++; }
                        //Console.WriteLine("{0} {1}", ope, count);
                    }
                    Console.WriteLine(count);
                }
            }
        }
    }
}
