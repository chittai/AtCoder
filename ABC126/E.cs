using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ABC126
{
    class E
    {
        static void Main()
        {

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int N = input[0];
            int M = input[1];

            List<int>[] list = new List<int>[N];

            for (int i = 0; i < N; i++)
            {
                list[i] = new List<int>();
            }

            int x = 0;
            int y = 0;
            for (int i = 0; i < M; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                x = input[0] - 1;
                y = input[1] - 1;
                list[x].Add(y);
                list[y].Add(x);
            }

            int count = 0;
            bool[] Used = new bool[N];

            Queue<int> q = new Queue<int>();
            for (int i = 0; i < N; i++)
            {
                if (Used[i]) continue;
                count++;
                Used[i] = true;
                q.Enqueue(i);

                while (q.Any())
                {
                    foreach (var item in list[q.Dequeue()])
                    {
                        if (Used[item]) continue;
                        Used[item] = true;
                        q.Enqueue(item);
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}