using System;
using System.Linq;

namespace ABC149
{
    class B
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long A = input[0];
            long B = input[1];
            long K = input[2];

            if (K <= A)
            {
                Console.WriteLine("{0} {1}", A - K, B);
            }
            else if (K - A <= B)
            {
                Console.WriteLine("{0} {1}", 0, B - (K - A));
            }
            else
            {
                Console.WriteLine("{0} {1}", 0, 0);
            }
        }
    }
}
