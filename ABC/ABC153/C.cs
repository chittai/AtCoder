using System;
using System.Linq;

namespace ABC153
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];
            int[] H = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();

            //Console.WriteLine(string.Join(",", H));

            long res = 0;
            for (int i = K; i < N; i++)
            {
                res += H[i];
            }

            Console.WriteLine(res);

        }
    }
}
