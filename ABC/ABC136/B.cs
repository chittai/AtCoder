using System;

namespace ABC136
{
    class A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int sum = 0;
            if (1 <= N && N <= 9)
            {
                Console.WriteLine(N);
            }

            sum += 9;

            if (10 <= N && N <= 99)
            {
                Console.WriteLine(sum);
            }

            if (100 <= N && N <= 999)
            {
                Console.WriteLine(sum + N - 100 + 1);
            }

            sum += (999 - 100 + 1);

            if (1000 <= N && N <= 9999)
            {
                Console.WriteLine(sum);
            }

            if (10000 <= N && N <= 99999)
            {
                Console.WriteLine(sum + N - 10000 + 1);
            }

            sum += (99999 - 10000 + 1);

            if (N == 100000)
            {
                Console.WriteLine(sum);
            }
        }
    }
}
