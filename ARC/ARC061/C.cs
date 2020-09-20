using System;
using System.Linq;

namespace ARC061
{
    class C
    {
        static void Main(string[] args)
        {
            //input
            string S = Console.ReadLine();
            int N = S.Length;

            long sum = 0;
            for (int i = 0; i < 1 << (N - 1); i++)
            {
                string s = S[0].ToString();
                for (int j = 1; j < N; j++)
                {
                    if ((i & (1 << (j - 1))) != 0)
                    {
                        s += "+";
                    }
                    s += S[j];
                }
                sum += s.Split('+').Select(long.Parse).Sum();
            }
            Console.WriteLine(sum);
        }
    }
}
