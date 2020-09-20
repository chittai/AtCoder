using System;
using System.Linq;

namespace ABC067
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int[] l = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();

            int res = 0;

            for (int i = 0; i < K; i++)
            {
                res += l[i];
            }

            Console.WriteLine(res);
        }
    }
}
