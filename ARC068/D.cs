using System;
using System.Linq;
using System.Collections.Generic;

namespace ARC068
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            int[] distinc_A = A.Distinct().OrderBy(x => x).ToArray();

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < N; i++)
            {
                if (!dict.ContainsKey(A[i])) dict.Add(A[i], 1);
                else dict[A[i]]++;
            }

            int even_count = 0;
            foreach (var i in distinc_A)
            {
                if (dict[i] % 2 == 0) { dict[i] = 2; even_count++; }
                else dict[i] = 1;
            }

            int res = 0;
            if (even_count % 2 == 0) res = distinc_A.Count();
            else res = distinc_A.Count() - 1;

            Console.WriteLine(res);
        }
    }
}
