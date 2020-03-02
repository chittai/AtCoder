using System;
using System.Linq;

namespace ABC115
{
    class B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var p = Enumerable.Repeat(0, N).Select(_ => int.Parse(Console.ReadLine())).ToArray();
            Console.WriteLine(p.Sum() - p.Max() + p.Max() / 2);
        }
    }
}
