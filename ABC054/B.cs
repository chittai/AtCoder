using System;
using System.Linq;

namespace ABC054
{
    class B
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];

            string[] A = new string[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = Console.ReadLine();
            }

            string[] B = new string[M];
            for (int i = 0; i < M; i++)
            {
                B[i] = Console.ReadLine();
            }

            string sb;
            string sa;
            int indexA = 0;
            int indexB = 0;
            bool isMatch = false;
            int count = 0;
            for (int i = 0; i < N - M + 1; i++)
            {
                sb = B[indexB];
                indexA = i;
                for (int j = 0; j < N - M + 1; j++)
                {
                    sa = A[i].Substring(j, sb.Length);
                    while (sa == sb && indexB < M && indexA < N)
                    {
                        count++;
                        sa = A[indexA].Substring(j, sb.Length);
                        sb = B[indexB];
                        indexA++;
                        indexB++;
                    }
                    if (indexB == M) { isMatch = true; }

                    indexB = 0;
                    if (isMatch) break;
                }
                if (isMatch) break;
            }

            if (isMatch) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
