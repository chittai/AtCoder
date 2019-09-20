using System;

namespace ARC004
{
    class A
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());

            double[] x = new double[N];
            double[] y = new double[N];

            string[] input;
            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine().Split();
                x[i] = int.Parse(input[0]);
                y[i] = int.Parse(input[1]);
            }

            double max = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    max = Math.Max(max, Math.Sqrt(Math.Pow(x[i] - x[j], 2) + Math.Pow(y[i] - y[j], 2)));
                }
            }
            Console.WriteLine(max);
        }
    }
}
