using System;

namespace ABC087
{
    class B
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());

            int Total = 0;
            int count = 0;
            for (int i = 0; i <= A; i++)
            {
                for (int j = 0; j <= B; j++)
                {
                    for (int k = 0; k <= C; k++)
                    {
                        Total = 500 * i + 100 * j + 50 * k;
                        if (Total == X) { count++; break; }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
