using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC109
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, int> wdic = new Dictionary<string, int>();

            string[] W = new string[N];
            for (int i = 0; i < N; i++)
            {
                W[i] = Console.ReadLine();
            }

            char last = ' ';
            for (int i = 0; i < N; i++)
            {
                if (wdic.ContainsKey(W[i])) { Console.WriteLine("No"); return; }
                else { wdic.Add(W[i], 1); }

                if (0 < i && W[i][0] != last) { Console.WriteLine("No"); return; }

                last = W[i][W[i].Length - 1];
            }

            Console.WriteLine("Yes");
        }
    }
}
