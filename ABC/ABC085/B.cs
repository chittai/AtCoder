using System;
using System.Linq;

namespace ABC085
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] d = new int[N];
            for (int i = 0; i < N; i++)
            {
                d[i] = int.Parse(Console.ReadLine());
            }

            d = d.OrderByDescending(x => x).Distinct().ToArray();
            Console.WriteLine(d.Count());
        }
    }
}
