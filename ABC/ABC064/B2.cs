using System;
using System.Linq;

namespace ABC064
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(a.Max() - a.Min());
        }
    }
}