using System;
using System.Linq;

namespace ABC144
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int A = input[0];
            int B = input[1];
            if (9 < A || 9 < B) { Console.WriteLine(-1); return; }
            else Console.WriteLine(A * B);
        }
    }
}
