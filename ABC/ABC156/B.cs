using System;
using System.Linq;
namespace ABC156
{
    class B
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long N = input[0];
            long K = input[1];

            long res = 0;

            long index = 0;
            while (Math.Pow(K, index) <= N)
            {
                index++;
            }

            res = index;

            Console.WriteLine(res);

        }
    }
}
