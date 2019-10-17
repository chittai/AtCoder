using System;
using System.Linq;

namespace AGC011
{
    class B
    {
        static void Main(string[] args)
        {

            long N = int.Parse(Console.ReadLine());
            long[] A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            A = A.OrderBy(x => x).ToArray();

            long[] S = new long[N + 1];
            for (int i = 1; i < N + 1; i++)
            {
                S[i] = S[i - 1] + A[i - 1];
            }

            int count = 0;
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] <= 2 * S[i]) count++;
                else { break; }
            }

            count++;
            Console.WriteLine(count);

        }
    }
}
