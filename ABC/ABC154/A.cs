using System;
using System.Linq;

namespace ABC154
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            string S = input[0];
            string T = input[1];
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int A = input2[0];
            int B = input2[1];
            string U = Console.ReadLine();

            if (U == S) A--;
            else B--;

            Console.WriteLine("{0} {1}", A, B);
        }
    }
}
