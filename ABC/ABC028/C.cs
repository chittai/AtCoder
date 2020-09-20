using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC028
{
    class C
    {
        static void Main(string[] args)
        {
            int[] alpha = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> l = new List<int>();
            for (int i = 0; i < alpha.Length - 2; i++)
            {
                for (int j = i + 1; j < alpha.Length - 1; j++)
                {
                    for (int k = j + 1; k < alpha.Length; k++)
                    {
                        l.Add(alpha[i] + alpha[j] + alpha[k]);
                    }
                }
            }

            l = l.OrderByDescending(x => x).ToList();
            Console.WriteLine(l[2]);

        }
    }
}
