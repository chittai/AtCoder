using System;
using System.Linq;

namespace ABC115
{
    class C
    {
        static void Main(string[] args)
        {
            var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var h = Enumerable.Repeat(0, NK[0]).Select(_ => int.Parse(Console.ReadLine())).ToArray();
            h = h.OrderBy(x => x).ToArray();
            int cost = int.MaxValue;
            for (int i = 0; i < NK[0] - NK[1] + 1; i++)
            {
                cost = Math.Min(cost, h[i + NK[1] - 1] - h[i]);
            }
            Console.WriteLine(cost);
        }
    }
}
