using System;

namespace AGC031
{
    class As
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string S = Console.ReadLine();
            long[] c = new long[26];
            long mod = 1000000007;

            for (int i = 0; i < N; i++)
            {
                c[S[i] - 'a']++;
            }

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] != 0) c[i]++;
            }

            //Console.WriteLine(string.Join(",", c));
            long res = 1;
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] != 0) res = (res * c[i]) % mod;
            }
            Console.WriteLine(res - 1);
        }
    }
}
