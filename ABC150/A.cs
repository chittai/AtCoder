using System;
using System.Linq;

namespace ABC150
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (input[1] <= 500 * input[0]) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
