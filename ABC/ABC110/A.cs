using System;
using System.Linq;

namespace ABC110
{
    class A
    {
        static void Main(string[] args)
        {
            var h = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();
            Console.WriteLine(h[0] * 10 + h[1] + h[2]);
        }
    }
}
