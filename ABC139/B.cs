using System;

namespace ABC139
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            int count = 1;
            for (int i = A; i < B; i += (A - 1))
            {
                count++;
            }
            if (B != 1) Console.WriteLine(count);
            else Console.WriteLine(0);

        }
    }
}