using System;
using System.Linq;
using System.Collections.Generic;

namespace MSBPC2019
{
    class D
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            string S = Console.ReadLine();

            int res = 0;
            for (int i = 0; i < 1000; i++)
            {
                string V = String.Format("{0:000}", i);
                int vindex = 0;
                int matchCount = 0;
                for (int j = 0; j < S.Length; j++)
                {
                    if (vindex < 3 && S[j] == V[vindex]) { vindex++; matchCount++; }
                }
                if (matchCount == 3) { res++; }
            }
            Console.WriteLine(res);
        }
    }
}
