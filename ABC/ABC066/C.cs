using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC066
{
    class C
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0) { list.Add(a[i]); }
                else { list.Insert(0, a[i]); }
            }

            if (n % 2 == 0) { list.Reverse(); }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
