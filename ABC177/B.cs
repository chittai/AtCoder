
using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
namespace ABC177
{
    class Program
    {
        static void Main(string[] args)
        {
            var S = Console.ReadLine();
            var T = Console.ReadLine();

            var ans = int.MaxValue;
            for (int i = 0; i < S.Length - T.Length + 1; i++)
            {
                var anstemp = 0;
                var Stemp = S.Substring(i, T.Length);
                //Console.WriteLine();
                for (int j = 0; j < T.Length; j++)
                {
                    if (Stemp[j] != T[j]) anstemp++;
                }

                ans = Math.Min(ans, anstemp);
            }
            Console.WriteLine(ans);
        }
    }
}
