using System;
using System.Linq;

namespace ABC069
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine((input[0] - 1) * (input[1] - 1));
        }
    }
}
