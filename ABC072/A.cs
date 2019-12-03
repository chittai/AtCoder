using System;
using System.Linq;

namespace ABC072
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int X = input[0];
            int t = input[1];

            if (X <= t) Console.WriteLine(0);
            else Console.WriteLine(X - t);

        }
    }
}
