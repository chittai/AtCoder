using System;
using System.Linq;

namespace ABC151
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int M = input[1];

            bool[] isAc = new bool[N];
            int[] waCount = new int[N];

            for (int i = 0; i < M; i++)
            {
                string[] input2 = Console.ReadLine().Split().ToArray();
                int p = int.Parse(input2[0]);
                string s = input2[1];

                if (isAc[p - 1]) continue;

                if (s == "AC") isAc[p - 1] = true;
                else waCount[p - 1]++;
            }

            int acRes = isAc.Count(x => x == true);
            int waCountRes = 0;

            for (int i = 0; i < N; i++)
            {
                if (isAc[i]) waCountRes += waCount[i];
            }

            Console.WriteLine("{0} {1}", acRes, waCountRes);

        }
    }
}
