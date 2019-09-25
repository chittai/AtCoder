using System;
using System.Linq;

namespace ABC093
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] ABC = new int[3] { int.Parse(input[0]), int.Parse(input[1]), int.Parse(input[2]) };

            int max = ABC.Max();
            if ((3 * max) % 2 != (ABC[0] + ABC[1] + ABC[2]) % 2) { max = ABC.Max() + 1; }

            Console.WriteLine(((3 * max) - (ABC[0] + ABC[1] + ABC[2])) / 2);
        }
    }
}
