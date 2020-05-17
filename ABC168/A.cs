using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC168
{
    class A
    {
        static void Main(string[] args)
        {
            //var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            //var abcd = Enumerable.Repeat(0, (int)Q).Select(_ => Console.ReadLine().Split().Select(long.Parse).ToArray()).ToArray();
            var S = Console.ReadLine();

            if (S[S.Length - 1] == '2' || S[S.Length - 1] == '4' || S[S.Length - 1] == '5' || S[S.Length - 1] == '7' || S[S.Length - 1] == '9')
                Console.WriteLine("hon");
            else if (S[S.Length - 1] == '0' || S[S.Length - 1] == '1' || S[S.Length - 1] == '6' || S[S.Length - 1] == '8')
                Console.WriteLine("pon");
            else
                Console.WriteLine("bon");
        }
    }
}