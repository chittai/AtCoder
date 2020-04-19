using System;
using System.Linq;

namespace ABC163
{
    class B
    {
        static void Main(string[] args)
        {
            var NM = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var ans = NM[0] - A.Sum();
            if (0 <= ans) Console.WriteLine(ans);
            else Console.WriteLine(-1);
        }
    }
}
