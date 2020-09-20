using System;

namespace CF2016qA
{
    class C
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int K = int.Parse(Console.ReadLine());

            char[] res = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                int x = 26 - (s[i] - 'a');
                if (x <= K) { res[i] = 'a'; K -= x % 26; }
                else { res[i] = s[i]; }
            }

            if (0 < K)
            {
                res[s.Length - 1] = (char)(res[s.Length - 1] + K % 26);
            }

            Console.WriteLine(res);
        }
    }
}
