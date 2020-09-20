using System;
using System.Linq;

namespace DDCC2020
{
    class A
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int X = input[0];
            int Y = input[1];

            int sum = 0;
            if (X == 3) { sum += 100000; }
            if (X == 2) { sum += 200000; }
            if (X == 1) { sum += 300000; }

            if (Y == 3) { sum += 100000; }
            if (Y == 2) { sum += 200000; }
            if (Y == 1) { sum += 300000; }


            if (X == 1 && Y == 1) { sum += 400000; }

            Console.WriteLine(sum);
        }
    }
}
