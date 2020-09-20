using System;

namespace ABC064
{
    class A
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int r = int.Parse(input[0]);
            int g = int.Parse(input[1]);
            int b = int.Parse(input[2]);

            if ((100 * r + 10 * g + b) % 4 == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
