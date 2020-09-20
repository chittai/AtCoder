using System;
using System.Linq;

namespace ABC086
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] t = new int[N + 1];
            int[] x = new int[N + 1];
            int[] y = new int[N + 1];

            x[0] = 0;
            y[0] = 0;
            t[0] = 0;

            for (int i = 1; i <= N; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                t[i] = int.Parse(input[0]);
                x[i] = int.Parse(input[1]);
                y[i] = int.Parse(input[2]);
            }

            int t2 = 0;
            int x2 = 0;
            int y2 = 0;
            for (int i = 0; i < N; i++)
            {
                x2 = x[i + 1] - x[i];
                y2 = y[i + 1] - y[i];
                t2 = t[i + 1] - t[i];

                if (t2 < (x2 + y2))
                {
                    Console.WriteLine("No");
                    return;
                }

                if ((t2 - (x2 + y2)) % 2 != 0)
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");

        }
    }
}
