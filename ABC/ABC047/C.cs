using System;

namespace ABC047
{
    class C
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            int count = 0;
            for (int i = 0; i < S.Length - 1; i++)
            {
                if (S[i] != S[i + 1]) { count++; }
            }
            Console.WriteLine(count);
        }
    }
}
