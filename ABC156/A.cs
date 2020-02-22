using System;
using System.Linq;
namespace ABC156
{
    class A
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //long[] input = Console.ReadLine().ToArray();
            long N = input[0];
            long R = input[1];

            if (10 <= N) Console.WriteLine(R);
            else { Console.WriteLine(R + 100 * (10 - N)); }

        }
    }
}
