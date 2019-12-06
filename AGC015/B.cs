using System;
using System.Linq;

namespace AGC015
{
    class B
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            long res = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'U') { res += 2 * i + (S.Length - (i + 1)); }
                else { res += 1 * i + (2 * (S.Length - (i + 1))); }
            }
            Console.WriteLine(res);
        }
    }
}
