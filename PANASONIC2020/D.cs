using System;
using System.Linq;
using System.Collections.Generic;

namespace PANASONIC2020
{
    class D
    {
        static int N;
        static void Main(string[] args)
        {
            N = int.Parse(Console.ReadLine());
            DFS("", 'a');
        }

        static void DFS(string S, char mx)
        {
            if (S.Length == N)
            {
                Console.WriteLine(S);
            }
            else
            {
                for (char c = 'a'; c <= mx; c++)
                {
                    DFS(S + c, ((c == mx) ? (char)(mx + 1) : mx));
                }
            }
        }
    }
}
