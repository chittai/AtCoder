using System;
using System.Linq;

namespace AGC005
{
    class A
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            int delete_count = 0;
            int s = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'S') s++;
                else
                {
                    if (0 < s) { delete_count++; s--; }
                }
            }

            Console.WriteLine(S.Length - 2 * delete_count);
        }
    }
}