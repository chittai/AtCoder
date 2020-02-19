using System;
using System.Linq;

namespace CF2014qA
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string A = input[0];
            int K = int.Parse(input[1]);

            int[,,] dp = new int[A.Length + 1, K, 2];

            for (int i = 0; i < A.Length; i++)
            {
                int nd = A[i] - '0';
                for (int k = 0; k < K; k++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        for (int d = 0; d < 10; d++)
                        {
                            int ni = i + 1;
                            int nk = k;
                            int nj = j;

                            if (K <= k) continue;

                            if (j == 0)
                            {
                                if (d > nd) continue;
                                if (d < nd) nk = 1;
                            }


                        }
                    }
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
}
