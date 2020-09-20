using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC016
{
    class C
    {
        static void Main(string[] args)
        {
            //input
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];

            List<int>[] list = new List<int>[N];
            for (int i = 0; i < N; i++)
            {
                list[i] = new List<int>();
            }

            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int A = input[0] - 1;
                int B = input[1] - 1;

                list[A].Add(B);
                list[B].Add(A);
            }

            /*
            foreach (var i in list)
            {
                Console.WriteLine(string.Join(",", i));
            }
             */

            int[] Res = new int[N];
            int count = 0;
            List<int> flist = new List<int>();
            //list[A]にある要素と、A自身を除いた数を足す
            for (int i = 0; i < N; i++)
            {
                count = 0;
                for (int j = 0; j < list[i].Count; j++)
                {
                    int temp = list[i][j];
                    for (int k = 0; k < list[temp].Count; k++)
                    {
                        if (list[temp][k] != i && !list[i].Contains(list[temp][k]) && !flist.Contains(list[temp][k]))
                        {
                            count++; flist.Add(list[temp][k]);
                        }
                    }
                }
                flist.Clear();
                Res[i] = count;
            }

            foreach (var i in Res)
            {
                Console.WriteLine(i);
            }
        }
    }
}
