using System;

namespace ABC088
{
    class C
    {
        static void Main(string[] args)
        {

            int[,] c = new int[3, 3];

            string[] input;
            for (int i = 0; i < 3; i++)
            {
                input = Console.ReadLine().Split();
                c[i, 0] = int.Parse(input[0]);
                c[i, 1] = int.Parse(input[1]);
                c[i, 2] = int.Parse(input[2]);
            }

            int[] a = new int[3];
            int[] b = new int[3];

            for (int i = 0; i <= Math.Max(Math.Max(c[0, 0], c[0, 1]), c[0, 2]); i++)
            {
                a[0] = i;
                for (int j = 0; j < 3; j++)
                {
                    b[j] = c[0, j] - a[0];
                }

                for (int j = 0; j <= Math.Max(Math.Max(c[1, 0], c[1, 1]), c[1, 2]); j++)
                {
                    if (c[1, 0] == j + b[0] && c[1, 1] == j + b[1] && c[1, 2] == j + b[2]) { a[1] = j; break; }
                    a[1] = -1;
                }

                for (int j = 0; j <= Math.Max(Math.Max(c[2, 0], c[2, 1]), c[2, 2]); j++)
                {
                    if (c[2, 0] == j + b[0] && c[2, 1] == j + b[1] && c[2, 2] == j + b[2]) { a[2] = j; break; }
                    a[2] = -1;
                }
            }

            if (0 <= a[1] && 0 <= a[2]) Console.WriteLine("Yes");
            else Console.WriteLine("No");

        }
    }
}
