using System;
using System.Linq;

namespace ABC085
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            long N = int.Parse(input[0]);
            long Y = int.Parse(input[1]);

            long sum = 0;
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= N - i; j++)
                {
                    sum += 10000 * i + 5000 * j + 1000 * (N - i - j);
                    if (sum == Y)
                    {
                        Console.WriteLine(i + " " + j + " " + (N - i - j));
                        return;
                    }
                    sum = 0;
                }
            }
            Console.WriteLine("-1" + " " + "-1" + " " + "-1");
        }
    }
}
