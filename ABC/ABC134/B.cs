using System;

namespace ABC134
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int D = int.Parse(input[1]);

            int count = 0;
            while (N > 0)
            {
                N -= 2 * D + 1;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
