using System;
using System.Linq;

namespace T1PBC2018
{
    class C
    {
        static void Main(string[] args)
        {
            //input, N, A
            int N = int.Parse(Console.ReadLine());
            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }

            //Aを降順でソートする
            A = A.OrderByDescending(x => x).ToArray();

            //A[0], A[1] , A[A.Length -1 ]
            //A[0] - A[A.Length -1], A[1] - A[A.Length -1]
            //L = A[0], R = A[1]　とする
            //2回目はMax(| L -A[A.Length -2]|,|R - A[A.Length -2]|) で、大きかったほう(L,R)を更新する
            //次はMax(| L -A[2]|,|R - A[2]]|) で、大きかったほう(L,R)を更新する

            int count = A[0] - A[A.Length - 1] + A[1] - A[A.Length - 1];
            int L = A[0];
            int R = A[1];

            int indexS = 2;
            int indexL = 2;

            for (int i = 0; i < N - 3; i++)
            {
                //小さい値
                if (i % 2 == 0)
                {
                    int temp = A[A.Length - indexS];

                    int tempL = Math.Abs(L - temp);
                    int tempR = Math.Abs(R - temp);

                    count += Math.Max(tempL, tempR);
                    if (tempL < tempR) { R = A[A.Length - indexS]; }
                    else { L = A[A.Length - indexS]; }
                    indexS++;
                }
                else
                {
                    int temp = A[indexL];

                    int tempL = Math.Abs(L - temp);
                    int tempR = Math.Abs(R - temp);

                    count += Math.Max(tempL, tempR);
                    if (tempL < tempR) { R = A[A.Length - indexS]; }
                    else { L = A[indexL]; }
                    indexL++;
                }
            }
            Console.WriteLine(count);
        }
    }
}