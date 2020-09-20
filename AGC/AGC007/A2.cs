using System;
using System.Linq;

namespace AGC007
{
    class A
    {
        static void Main(string[] args)
        {
            long sum = 0;
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int H = input[0];
            int W = input[1];
            sum = H + W - 1;
            for (int h = 0; h < H; h++)
            {
                sum -= Console.ReadLine().ToCharArray().Count(x => x == '#');
            }
            if (sum == 0) Console.WriteLine("Possible");
            else Console.WriteLine("Impossible");
        }
    }
}
