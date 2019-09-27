using System;
using System.Linq;

namespace ABC121
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int C = int.Parse(input[2]);

            int counnt = 0;
            int res = 0;

            int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < N; i++)
            {
                res = 0;
                int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < M; j++)
                {
                    res += A[j] * B[j];
                }
                if (res + C > 0) { counnt++; }
            }
            Console.WriteLine(counnt);
        }
    }
}
