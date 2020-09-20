using System;

namespace ABC121
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);

            input = Console.ReadLine().Split();
            int h = int.Parse(input[0]);
            int w = int.Parse(input[1]);

            Console.WriteLine((H * W) - (h * W) - ((H - h) * w));
        }
    }
}
