using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC164
{
    class D
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var S = new long[input.Length + 1];
            for (int i = 0; i < input.Length; i++)
            {
                S[i + 1] = long.Parse(input.Substring(input.Length - 1 - i, i + 1));
            }

            //Console.WriteLine(string.Join(",", S));

            var sum = 0;
            for (int i = 0; i < input.Length + 1; i++)
            {
                for (int j = i - 1; 0 <= j; j--)
                {
                    //Console.WriteLine((S[i] - S[j]) / Math.Pow(10, j));
                    if (((S[i] - S[j]) / Math.Pow(10, j)) % 2019 == 0) sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
