using System;

namespace T1PC2017
{
    class C
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            for (int h = 1; h <= 3500; h++)
            {
                for (int n = 1; n <= 3500; n++)
                {
                    if (4 * h * n - N * n - N * h > 0)
                    {
                        if ((N * h * n) % (4 * h * n - N * n - N * h) == 0)
                        {
                            Console.WriteLine("{0} {1} {2}", h, n, (N * h * n) / (4 * h * n - N * n - N * h));
                            return;
                        }
                    }
                }
            }
        }
    }
}
