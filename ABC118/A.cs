using System;
using System.IO;
using System.Linq;

namespace ABC118
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int A = input[0];
            int B = input[1];
            if (B % A == 0) Console.WriteLine(A + B);
            else Console.WriteLine(B - A);
        }
    }
}
