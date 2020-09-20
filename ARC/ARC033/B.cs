using System;
using System.Linq;
using System.Collections.Generic;

namespace ARC033
{
    class B
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int NA = input[0];
            int NB = input[1];

            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < NA; i++)
            {
                if (!dict.ContainsKey(A[i])) { dict.Add(A[i], 1); }
                else { dict[A[i]]++; }
            }

            for (int i = 0; i < NB; i++)
            {
                if (!dict.ContainsKey(B[i])) { dict.Add(B[i], 1); }
                else { dict[B[i]]++; }
            }

            double count = 0;
            foreach (var i in dict)
            {
                if (1 < i.Value) count++;
            }
            Console.WriteLine(count / (double)dict.Count);
        }
    }
}
