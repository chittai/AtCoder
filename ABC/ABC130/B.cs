using System;

namespace ABC130
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int X = int.Parse(input[1]);

            input = Console.ReadLine().Split(' ');
            int d = 0;
            int count = 1;
            for (int i = 0; i < N; i++)
            {
                d = d + int.Parse(input[i]);

                if (X < d) break;

                count++;
            }
            Console.WriteLine(count);
        }
    }
}
