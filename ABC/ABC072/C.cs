using System;
using System.Linq;

namespace ABC072
{
    class C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] res = new int[a.Max() + 2];

            foreach (var item in a)
            {
                res[item + 1] += 1;
                res[item] += 1;
                if (0 < item) res[item - 1] += 1;

            }
            Console.WriteLine(res.Max());
        }
    }
}
