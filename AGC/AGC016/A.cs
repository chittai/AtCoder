using System;
using System.Linq;

namespace AGC016
{
    class A
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().ToCharArray();

            int[] c = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                c[s[i] - 'a']++;
            }

            int min = int.MaxValue;
            for (char x = 'a'; x <= 'z'; x++)
            {
                if (0 < c[x - 'a'])
                {
                    var S2 = new string(s).ToCharArray();
                    while (S2.Distinct().Count() > 1)
                    {
                        for (int j = 0; j < S2.Length - 1; j++)
                        {
                            if (S2[j + 1] == x) { S2[j] = x; }
                        }
                        S2 = S2.Where((n, i) => i < S2.Length - 1).ToArray();
                    }
                    min = Math.Min(min, s.Length - S2.Length);
                }
            }
            if (min == int.MaxValue) { min = 0; }
            Console.WriteLine(min);
        }
    }
}
