using System;
using System.Linq;

namespace ABC101
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];

            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = 0;
            int res = 1;
            while (true)
            {
                if (N <= (K + n * K - n)) break;
                n++;
                res++;
            }

            Console.WriteLine(res);
        }
    }
}
