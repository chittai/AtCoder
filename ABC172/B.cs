using System;
using System.Linq;

namespace ABC172
{
    class B
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();
            var T = Console.ReadLine();

            var ans = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] != T[i]) ans++;
            }

            Console.WriteLine(ans);

        }
    }
}
