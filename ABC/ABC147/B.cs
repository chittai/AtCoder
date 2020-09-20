using System;
using System.Linq;

namespace ABC147
{
    class B
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            int res = 0;
            for (int i = 0; i < S.Length / 2; i++)
            {
                if (S[i] != S[S.Length - 1 - i]) res++;
            }

            Console.WriteLine(res);

        }
    }
}
