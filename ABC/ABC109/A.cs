using System;
using System.Linq;

namespace ABC109
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int A = input[0];
            int B = input[1];

            if (A % 2 == 0 || B % 2 == 0) Console.WriteLine("No");
            else Console.WriteLine("Yes");
        }
    }
}
