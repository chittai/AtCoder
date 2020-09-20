using System;
using System.Collections.Generic;
using System.Linq;

namespace ABC124

{
    class D
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];
            string S = Console.ReadLine();

            List<int> list = new List<int>();
            int count;

            for (int i = 0; i < S.Length; i++)
            {
                if (i == 0 && S[0] != '1')
                {
                    list.Add(0);
                }

                count = 1;
                while (1 < S.Length && i < S.Length - 1 && S[i] == S[i + 1])
                {
                    count++;
                    i++;
                }
                list.Add(count);
            }

            if (S.Length == 1)
            {
                if (S[0] == '1') { list.Add(1); list.Add(0); }
                else { list.Add(0); list.Add(1); }
            }

            var Count = list.ToArray();

            int[] CS = new int[Count.Length + 2];
            CS[0] = 0;
            for (int i = 1; i < Count.Length; i++)
            {
                CS[i] = CS[i - 1] + Count[i - 1];
            }
            CS[Count.Length] = CS[Count.Length - 1] + Count[Count.Length - 1];
            CS[Count.Length + 1] = CS[Count.Length - 1] + Count[Count.Length - 1];

            int max = 0;
            for (int i = 0; i + 2 * K + 1 < CS.Length; i += 2)
            {
                max = Math.Max(max, CS[i + 2 * K + 1] - CS[i]);
            }

            if (S.Length == 1) max = 1;
            if (CS.Length / 2 <= K) max = S.Length;

            Console.WriteLine(max);
        }
    }
}