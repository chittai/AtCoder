using System;
using System.Linq;

namespace ABC155
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int A = input[0];
            int B = input[1];
            int C = input[2];

            int count = 0;
            if (A == B) count++;
            if (B == C) count++;
            if (C == A) count++;

            if (count == 1) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
