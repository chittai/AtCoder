using System;
using System.Linq;
using System.Collections.Generic;

namespace D2019PC2
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] X = new int[N];
            int[] Y = new int[N];
            for (int i = 0; i < N; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                X[i] = input[0];
                Y[i] = input[1];
            }

            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i != j)
                    {
                        string xy = (X[j] - X[i]).ToString() + (Y[j] - Y[i]).ToString();
                        if (!dict.ContainsKey(xy)) { dict.Add(xy, 1); }
                        else dict[xy]++;
                    }
                }
            }

            int res = int.MaxValue;

            if (N == 1) { Console.WriteLine(1); return; }

            foreach (var i in dict)
            {
                res = Math.Min(res, N - i.Value);
            }
            Console.WriteLine(res);
        }
    }
}
