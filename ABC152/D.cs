using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC152
{
    class D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Dictionary<Tuple<int, int>, int> dict = new Dictionary<Tuple<int, int>, int>();
            for (int i = 1; i <= N; i++)
            {
                int head = 0;
                int tail = 0;
                int num = i;
                tail = num % 10;
                num /= 10;

                if (1 <= i && i <= 9)
                {
                    // 一桁の時
                    head = i;
                }
                else
                {
                    // 二桁以上の時
                    while (0 < num)
                    {
                        head = num % 10;
                        num /= 10;
                    }
                }

                Tuple<int, int> t = Tuple.Create(head, tail);
                if (!dict.ContainsKey(t)) dict.Add(t, 1);
                else dict[t]++;
            }

            long res = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Tuple<int, int> t2 = Tuple.Create(i, j);
                    Tuple<int, int> t3 = Tuple.Create(j, i);
                    if (dict.ContainsKey(t2) && dict.ContainsKey(t3)) res += dict[t2] * dict[t3];
                }
            }
            Console.WriteLine(res);
        }
    }
}
