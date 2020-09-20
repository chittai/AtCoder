using System;
using System.Linq;

namespace AGC018
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];

            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int res = A[0];
            for (int i = 1; i < N; i++)
            {
                res = CalcGCD(res, A[i]);
            }
            if (K % res == 0 && K <= A.Max()) Console.WriteLine("POSSIBLE");
            else Console.WriteLine("IMPOSSIBLE");
        }

        public static int CalcGCD(int a, int b)
        {
            if (b == 0) { return a; }
            return CalcGCD(b, a % b);
        }

    }
}
