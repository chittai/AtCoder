using System;

namespace ABC139
{
    class A
    {
        static void Main(string[] args)
        {
            int count = 0;
            string S = Console.ReadLine();
            string T = Console.ReadLine();
            if (S[0] == T[0]) count++;
            if (S[1] == T[1]) count++;
            if (S[2] == T[2]) count++;
            Console.WriteLine(count);
        }
    }
}
