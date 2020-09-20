using System;

namespace KPC2019
{
    class B
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();
            var s = "keyence";

            if (S.Substring(0, s.Length) == s) { Console.WriteLine("YES"); return; }
            if (S.Substring((S.Length - s.Length) - 1, s.Length) == s) { Console.WriteLine("YES"); return; }


            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (S[i] != s[i]) break;
                res++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (S[S.Length - 1 - i] != s[s.Length - 1 - i]) break;
                res++;
            }

            if (s.Length <= res)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
