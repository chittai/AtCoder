using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC094
{
    class A
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> a = Console.ReadLine().Split().Select(int.Parse).ToList();
            a = a.OrderBy(x => x).ToList();

            int max = a[a.Count - 1];
            int index = a.BinarySearch(max / 2);
            int minIndex2 = 0;

            if (index < 0)
            {
                index = ~index;
                minIndex2 = index - 1;
                index = Math.Abs(a[index] - max / 2d) < Math.Abs(a[minIndex2] - max / 2d) ? index : minIndex2;
            }

            int min = a[index];
            Console.WriteLine("{0} {1}", max, min);

        }
    }
}
