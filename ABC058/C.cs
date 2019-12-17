using System;
using System.Linq;

namespace ABC058
{
    class C
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] count = new int[26, n];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    count[s[j] - 'a', i]++;
                }
            }

            int[] res = new int[26].Select(x => x = 1000000).ToArray();
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (count[i, j] == 0) { res[i] = 0; break; }
                    else res[i] = Math.Min(res[i], count[i, j]);
                }
            }

            string ans = "";
            for (int i = 0; i < 26; i++)
            {
                if (res[i] != 0 && res[i] < 1000000)
                {
                    for (int j = 0; j < res[i]; j++)
                    {
                        ans += (char)(i + 'a');
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}
