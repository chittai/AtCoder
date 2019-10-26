using System;
using System.Linq;

namespace AGC015
{
    class A
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long N = input[0];
            long A = input[1];
            long B = input[2];

            if (N == 1)
            {
                if (A == B) { Console.WriteLine(1); return; }
                else { Console.WriteLine(0); return; }
            }
            else
            {
                if (B < A) { Console.WriteLine(0); return; }
                else Console.WriteLine((B - A) * (N - 2) + 1);
            }
        }
    }
}
