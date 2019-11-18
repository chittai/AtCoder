using System;
using System.Linq;

namespace ABC078
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long M = input[1];
            Console.WriteLine(Math.Pow(2, M) * (1900 * M + 100 * (N - M)));
        }
    }
}
