using System;
using System.Linq;

namespace ABC147
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (22 <= input.Sum()) Console.WriteLine("bust");
            else Console.WriteLine("win");
        }
    }
}
