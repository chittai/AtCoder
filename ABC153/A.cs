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
            int A = input[1];

            if (H % A == 0) { Console.WriteLine(H / A); }
            else { Console.WriteLine(H / A + 1); }
        }
    }
}
