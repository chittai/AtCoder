using System;
using System.Linq;

namespace ABC153
{
    class B
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = input[0];
            int N = input[1];
            int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = A.Sum();

            if (H <= sum) { Console.WriteLine("Yes"); }
            else { Console.WriteLine("No"); }
        }
    }
}
