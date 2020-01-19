using System;
using System.Linq;

namespace ABC152
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] P = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int min = int.MaxValue;
            int res = 0;
            for (int i = 0; i < N; i++)
            {
                if (P[i] <= min) { res++; }
                min = Math.Min(min, P[i]);
            }

            Console.WriteLine(res);
        }
    }
}
