
using System;

namespace ABC131
{
    class A
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            char tmp = S[0];
            for (int i = 1; i < 4; i++)
            {
                if (tmp == S[i])
                {
                    Console.WriteLine("Bad");
                    return;
                }
                else
                {
                    tmp = S[i];
                }
            }
            Console.WriteLine("Good");
        }
    }
}
