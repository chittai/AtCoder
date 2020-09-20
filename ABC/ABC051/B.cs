using System;

namespace ABC051
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int K = int.Parse(input[0]);
            int S = int.Parse(input[1]);

            int count = 0;
            for (int x = 0; x <= K; x++)
            {
                for (int y = 0; y <= K; y++)
                {
                    int z = S - (x + y);
                    if (0 <= z && z <= K) { count++; }
                }
            }
            Console.WriteLine(count);
        }
    }
}
