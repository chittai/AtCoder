using System;
using System.Linq;

namespace ABC151
{
    class B
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];
            int M = input[2];
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = A.Sum();

            int res = N * M - sum;
            if (res <= 0) Console.WriteLine(0);
            else if (K < res) Console.WriteLine(-1);
            else Console.WriteLine(res);
        }
    }
}
