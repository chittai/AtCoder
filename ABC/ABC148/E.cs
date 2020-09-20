using System;
using System.Linq;

namespace ABC148
{
    class E
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            if (N % 2 != 0) { Console.WriteLine(0); return; }

            long res = 0;
            N /= 2;
            while (5 <= N)
            {
                res += N / 5;
                N /= 5;
            }
            Console.WriteLine(res);

        }
    }
}
