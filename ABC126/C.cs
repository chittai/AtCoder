
using System;
using System.Linq;

namespace ABC126
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s1 = Console.ReadLine().Split(' ');
            double[] n1 = s1.Select(x => double.Parse(x)).ToArray();

            int[] n2 = s1.Select(x => int.Parse(x)).ToArray();
            double[] n = new double[n2[0]];

            double p = 1;
            for (int i = 0; i < n2[0]; i++)
            {
                while (n2[1] <= i * Math.Pow(2, p))
                {
                    p++;
                }
                n[i] = p;
            }

            double d = 0;
            for (int i = 0; i < n1[0]; i++)
            {
                if (i < n1[1])
                {
                    d += (1 / n1[0]) * (Math.Pow(0.5, n[i]));
                    Console.WriteLine(d);
                }
                else
                {
                    d += (1 / n1[0]);
                    Console.WriteLine(d);
                }
            }

        }
    }
}
