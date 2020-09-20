using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC134
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var iList = new List<int>();
            var res = new int[N + 1];
            for (int i = N; i > 0; i--)
            {
                var j = 1;
                var sum = 0;
                while (i * j <= N)
                {
                    sum += res[i * j];
                    j++;
                }
                if (sum % 2 != a[i - 1]) { res[i] = 1; iList.Add(i); }
            }

            Console.WriteLine(iList.Count);
            if (iList.Count != 0) Console.WriteLine(string.Join(" ", iList));
        }
    }
}