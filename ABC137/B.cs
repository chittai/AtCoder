using System;

namespace ABC137
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int K = int.Parse(input[0]);
            int X = int.Parse(input[1]);

            for (int i = (K - 1) * (-1); i < K; i++)
            {
                Console.Write(X + i);
                if (i < K - 1) Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
