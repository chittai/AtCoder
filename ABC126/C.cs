
using System;
using System.Linq;

namespace ABC126
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double N = double.Parse(input[0]);
            double K = double.Parse(input[1]);

            double d = 0;
            double point = 0;
            for (double i = 1; i <= N; i++)
            {
                point = i;
                for (double j = 0; j <= 17; j++)
                {
                    if (K <= point)
                    {
                        d += ((1 / N) * Math.Pow(0.5, j));
                        break;
                    }
                    point = point * 2.0;
                }
            }
            Console.WriteLine(d);
        }
    }
}
