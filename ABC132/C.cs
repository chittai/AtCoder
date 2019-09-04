using System;

namespace ABC132
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int[] d = new int[N];
            for (int i = 0; i < N; i++)
            {
                d[i] = int.Parse(input[i]);
            }

            Array.Sort(d);

            int[] s = new int[N];
            int tmp = d[0];
            int res = 0;
            for (int i = 0; i < N - 1; i++)
            {
                if (tmp != d[i + 1])
                {
                    if (d.Length - (i + 1) == (i + 1))
                    {
                        res = d[i + 1] - d[i];
                        Console.WriteLine(res);
                        return;
                    }
                    tmp = d[i + 1];
                }
            }

            Console.WriteLine(0);

        }
    }
}
