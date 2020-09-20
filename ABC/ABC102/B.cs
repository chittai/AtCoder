using System;
using System.Linq;

namespace ABC102
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(A.Max() - A.Min());
        }
    }
}
