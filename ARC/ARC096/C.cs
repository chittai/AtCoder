
using System;

namespace ARC096
{
    class C
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);
            int C = int.Parse(input[2]);
            int X = int.Parse(input[3]);
            int Y = int.Parse(input[4]);

            int sum = 0;

            if (2 * C <= A + B)
            {
                while (0 < X && 0 < Y)
                {
                    sum += 2 * C;
                    X--; Y--;
                }
            }

            while (0 < X)
            {
                if (2 * C < A) sum += 2 * C;
                else sum += A;
                X--;
            }

            while (0 < Y)
            {
                if (2 * C < B) sum += 2 * C;
                else sum += B;
                Y--;
            }
            Console.WriteLine(sum);
        }
    }
}
