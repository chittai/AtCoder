using System;

namespace ABC084
{
    class B
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            string S = Console.ReadLine();

            bool res;
            for (int i = 0; i < A; i++)
            {
                res = Char.IsDigit(S[i]);
                if (!res)
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            if (S[A] != '-')
            {
                Console.WriteLine("No");
                return;
            }

            for (int i = A + 1; i < A + 1 + B; i++)
            {
                res = Char.IsDigit(S[i]);
                if (!res)
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
    }
}
