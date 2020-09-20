using System;
using System.Linq;

namespace ZTP001
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int A = input[1];
            int B = input[2];

            Console.WriteLine("{0} {1}", Math.Min(A, B), Math.Max(0, A + B - N));
        }
    }
}
