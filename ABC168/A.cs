using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC168
{
    class B
    {
        static void Main(string[] args)
        {
            //var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var abcd = Enumerable.Repeat(0, (int)Q).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            var K = int.Parse(Console.ReadLine());
            var S = Console.ReadLine();

            if (S.Length <= K)
                Console.WriteLine(S);
            else
                Console.WriteLine(S.Substring(0, K) + "...");
        }
    }
}
