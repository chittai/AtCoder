using System;
using System.Linq;

namespace PAST001
{
    class C
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();
            Console.WriteLine(input[2]);
        }
    }
}
