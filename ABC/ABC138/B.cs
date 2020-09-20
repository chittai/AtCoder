using System;

namespace ABC138
{
    class B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');

            double sum = 0.0000f;

            for (int i = 0; i < N; i++)
            {
                sum += (1f / int.Parse(input[i]));
            }

            double res = (1 / sum);
            Console.WriteLine(res);
        }
    }
}
