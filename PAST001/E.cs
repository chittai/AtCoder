using System;
using System.Linq;
using System.Collections.Generic;

namespace PAST001
{
    class E
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int Q = input[1];

            char[,] Res = new char[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Res[i, j] = 'N';
                }
            }

            for (int i = 0; i < Q; i++)
            {
                //Console.WriteLine(Res[0, 2]);
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (2 < input.Length)
                {
                    int y = input[1] - 1;
                    int x = input[2] - 1;
                    Res[y, x] = 'Y';
                }
                else
                {
                    int a = input[1] - 1;
                    if (input[0] == 2) // 2
                    {
                        for (int j = 0; j < N; j++)
                        {
                            if (Res[j, a] == 'Y')
                            {
                                Res[a, j] = 'Y';
                            }
                        }
                    }
                    else // 3
                    {
                        List<int> l = new List<int>();
                        for (int j = 0; j < N; j++)
                        {
                            if (Res[a, j] == 'Y')
                            {
                                l.Add(j);
                            }
                        }
                        for (int j = 0; j < l.Count; j++)
                        {
                            for (int k = 0; k < N; k++)
                            {
                                if (Res[l[j], k] == 'Y')
                                {
                                    if (a != k) Res[a, k] = 'Y';
                                    //Console.WriteLine("{0} {1} {2} {3}", j, a, k, Res[0, 2]);
                                }
                            }

                        }
                    }
                }

            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(Res[i, j]);
                }
                Console.WriteLine();
            }


        }
    }
}
