using System;

namespace ABC047
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int W = int.Parse(input[0]);
            int H = int.Parse(input[1]);
            int N = int.Parse(input[2]);

            int x0 = 0;
            int y0 = 0;
            int x1 = W;
            int y1 = H;

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split();
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);
                int a = int.Parse(input[2]);

                if (a == 1)
                {
                    x0 = Math.Max(x0, x);
                }

                if (a == 2)
                {
                    x1 = Math.Min(x1, x); ;
                }

                if (a == 3)
                {
                    y0 = Math.Max(y0, y);
                }

                if (a == 4)
                {
                    y1 = Math.Min(y1, y);
                }
            }

            if ((x1 - x0) < 0 || (y1 - y0) < 0) Console.WriteLine(0);
            else Console.WriteLine((x1 - x0) * (y1 - y0));
        }
    }
}
