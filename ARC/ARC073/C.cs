using System;
using System.Linq;

namespace ARC073
{
    class C
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var N = a[0];
            var T = a[1];
            var res = T;
            var t = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < N - 1; i++)
            {
                var tempt = t[i + 1] - t[i];
                if (T <= tempt) res += T;
                else res += tempt;
            }
            Console.WriteLine(res);
        }
    }
}
