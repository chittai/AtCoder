using System;
using System.Linq;

namespace ABC113
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            int T = int.Parse(input[0]);
            double A = double.Parse(input[1]);

            double[] H = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            double min = double.MaxValue;
            double h = 0;
            int index = 0;
            double keisu = 0.006;
            for (int i = 0; i < N; i++)
            {
                h = T - H[i] * keisu;
                if (Math.Abs(A - h) < min)
                {
                    min = Math.Abs(A - h);
                    index = i + 1;
                }
            }
            Console.WriteLine(index);
        }
    }
}
