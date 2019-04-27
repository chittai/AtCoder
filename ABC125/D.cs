using System;
using System.Linq;

namespace ABC125
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] a = Console.ReadLine().Split(' ');
            int[] an = a.Select(x => int.Parse(x)).ToArray();

            for (int i = 0; i < n - 1; i++)
            {
                if (an[i] < 0 && an[i + 1] < 0)
                {
                    an[i] *= -1;
                    an[i + 1] *= -1;
                }

                if (an[i] < 0 && Math.Abs(an[i]) > Math.Abs(an[i + 1]))
                {
                    an[i] *= -1;
                    an[i + 1] *= -1;
                }
            }

            int result = 0;
            foreach (int x in an)
            {
                result += x;
            }
            Console.WriteLine(result);
        }

    }
}
